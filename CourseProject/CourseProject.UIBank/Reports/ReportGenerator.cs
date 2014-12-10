using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CourseProject.Core.Entities;
using GemBox.Document;
using GemBox.Document.Tables;

namespace CourseProject.UIBank.Reports
{
  public class ReportGenerator
  {
    public static void Generate(ICollection<Account> accounts, ICollection<Deposit> deposits, ICollection<Loan> loans, Customer customer)
    {
      ComponentInfo.SetLicense("FREE-LIMITED-KEY");
      ComponentInfo.FreeLimitReached += (s, args) => args.FreeLimitReachedAction = FreeLimitReachedAction.ContinueAsTrial;

      var document = new DocumentModel();

      var mainParagraph = new Paragraph(document, new Run(document, String.Format("Отчёт по счетам, депозитам, займам заказчика ({0}):", customer.FullName)));

      var table = new Table(document);

      GenerateRowsForAccounts(accounts, document, table);

      GenerateRowsForDeposits(deposits, document, table);

      GenerateRowsForLoans(loans, document, table);

      var mainSection = new Section(document, mainParagraph, new Paragraph(document, new SpecialCharacter(document, SpecialCharacterType.LineBreak)), table);

      document.Sections.Add(mainSection);

      var path = GeneratePath(customer.FullName);
      document.Save(path);
    }

    private static void GenerateRowsForAccounts(ICollection<Account> accounts, DocumentModel document, Table table)
    {
      var rowAccountCount = accounts.Count;

      for (int i = 0; i < rowAccountCount; i++)
      {
        var account = accounts.ElementAt(i);
        var row = new TableRow(document);
        table.Rows.Add(row);

        var cells = new List<TableCell>();

        var paragraph = new Paragraph(document, (i + 1).ToString());
        var cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, String.Format("Account Id - {0}", account.Id));
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, account.CreateDate.ToShortDateString());
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, "Type of account - Common");
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, String.Format("{0} {1}", account.Summary, account.Currency.Value));
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        AddCellsToRow(row, cells);
      }
    }

    private static void GenerateRowsForDeposits(ICollection<Deposit> deposits, DocumentModel document, Table table)
    {
      var rowDepositCount = deposits.Count;

      for (int i = 0; i < rowDepositCount; i++)
      {
        var deposit = deposits.ElementAt(i);
        var row = new TableRow(document);
        table.Rows.Add(row);

        var cells = new List<TableCell>();

        var paragraph = new Paragraph(document, (i + 1).ToString());
        var cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, String.Format("Deposit Id - {0}", deposit.Id));
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, deposit.CreateDate.ToShortDateString());
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, String.Format("Type of deposit - {0}", deposit.OptionDeposit.Name));
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, String.Format("{0} {1}", deposit.Summary, deposit.Currency.Value));
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        AddCellsToRow(row, cells);
      }
    }

    private static void GenerateRowsForLoans(ICollection<Loan> loans, DocumentModel document, Table table)
    {
      var rowLoanCount = loans.Count;

      for (int i = 0; i < rowLoanCount; i++)
      {
        var loan = loans.ElementAt(i);
        var row = new TableRow(document);
        table.Rows.Add(row);

        var cells = new List<TableCell>();

        var paragraph = new Paragraph(document, (i + 1).ToString());
        var cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, String.Format("Loan Id - {0}", loan.Id));
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, loan.CreateDate.ToShortDateString());
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, String.Format("Type of loan - {0}", loan.OptionLoan.Name));
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        paragraph = new Paragraph(document, String.Format("{0} {1}", loan.Summary, loan.Currency.Value));
        cell = new TableCell(document, paragraph);
        cells.Add(cell);

        AddCellsToRow(row, cells);
      }
    }

    private static void AddCellsToRow(TableRow row, List<TableCell> cells)
    {
      foreach (var cell in cells)
      {
        row.Cells.Add(cell);
      }
    }

    private static string GeneratePath(string customerFullName, string type = "pdf")
    {
      var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
      path += "\\Reports\\" + customerFullName + "." + type;
      return path;
    }
  }
}