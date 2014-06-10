using System;
using System.Collections.Generic;
using System.Diagnostics;
using DumaProject.BLInterfaces.BLLInterfaces;
using DumaProject.Core.Entities;
using GemBox.Document;
using GemBox.Document.Tables;

namespace DumaProject.Services
{
    public class ReportService : IReportService
    {
        public void GenerateReportForMeeting(Meeting meeting, Commission commission, string type)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            ComponentInfo.FreeLimitReached +=
                (s, args) => args.FreeLimitReachedAction = FreeLimitReachedAction.ContinueAsTrial;

            var document = new DocumentModel();

            //String.Format(
            //    "Отчёт по встрече комиссии, специализирующейся на профиле ({0}).{1} Название комиссии - {2}.{1} Количество человек : {3} {1} " +
            //    "День проведения - {4} {1} Место встречи - {5} {1} Дата начала собрания - {6} {1} Длительность - {7} {1} УЧАСТНИКИ: {1}",
            //    commission.Profile.Description, Environment.NewLine, commission.Name, commission.Consist.Count,
            //    meeting.Date.ToShortDateString(), meeting.Venue, meeting.Date.ToShortTimeString(),
            //    meeting.DurationInMinutes)),

            var mainParagraph = new Paragraph(document,
                new Run(document,
                    String.Format("Отчёт по встрече комиссии, специализирующейся на профиле ({0})",
                        commission.Profile.Description)),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, String.Format("Название комиссии - {0}", commission.Name)),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, String.Format("Количество человек : {0}", commission.Consist.Count)),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, String.Format("День проведения - {0}", meeting.Date.ToShortDateString())),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, String.Format("Место встречи - {0}", meeting.Venue)),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, String.Format("Дата начала собрания - {0}", meeting.Date.ToShortTimeString())),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, String.Format("Длительность - {0} минут", meeting.DurationInMinutes)),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, String.Format("УЧАСТНИКИ:")),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak));

            var table = new Table(document);

            var rowCount = meeting.Participants.Count;

            for (int i = 0; i < rowCount; i++)
            {
                var participant = meeting.Participants[i];
                var row = new TableRow(document);
                table.Rows.Add(row);

                var cells = new List<TableCell>();

                var paragraph = new Paragraph(document, (i + 1).ToString());
                var cell = new TableCell(document, paragraph);
                cells.Add(cell);

                paragraph = new Paragraph(document, participant.Name);
                cell = new TableCell(document, paragraph);
                cells.Add(cell);

                paragraph = new Paragraph(document, participant.Surname);
                cell = new TableCell(document, paragraph);
                cells.Add(cell);

                paragraph = new Paragraph(document, participant.Patronymic);
                cell = new TableCell(document, paragraph);
                cells.Add(cell);

                paragraph = new Paragraph(document, participant.Role.ToString());
                cell = new TableCell(document, paragraph);
                cells.Add(cell);

                paragraph = new Paragraph(document, participant.PassportData);
                cell = new TableCell(document, paragraph);
                cells.Add(cell);

                AddCellsToRow(row, cells);
            }

            var mainSection = new Section(document, mainParagraph,
                new Paragraph(document, new SpecialCharacter(document, SpecialCharacterType.LineBreak)), table);

            document.Sections.Add(mainSection);

            var path = String.Format("{0}\\{1}.{2}", Environment.CurrentDirectory,
                String.Format("{0}-{1}", meeting.Commission.ToString(), meeting.Date.ToFileTime()), type);
            document.Save(path);

            Process.Start(path);
        }

        private void AddCellsToRow(TableRow row, List<TableCell> cells)
        {
            foreach (var cell in cells)
            {
                row.Cells.Add(cell);
            }
        }
    }
}
