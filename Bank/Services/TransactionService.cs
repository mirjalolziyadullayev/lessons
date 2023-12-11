using Bank.Interfaces;
using Bank.Models;

namespace Bank.Services;

public class TransactionService : ITransactionInterface
{
    List<Transaction> transactions;
    public TransactionService()
    {
        transactions = new List<Transaction>();
    }
    public void Create(Transaction trasaction)
    {
        transactions.Add(trasaction);
    }
    public List<Transaction> GetAllByCardID(int id)
    {
        List<Transaction> transactionsByID = new List<Transaction>();
        foreach (Transaction transaction in transactions)
        {
            if (transaction.CardID == id)
            {
                transactionsByID.Add(transaction);
            }
        }
        return transactionsByID;
    }
    public List<Transaction> GetAllByCustomerID(int id)
    {
        List<Transaction> transactionsByCustomerID = new List<Transaction>();
        foreach (Transaction transaction in transactions)
        {
            if (transaction.CustomerID == id)
            {
                transactionsByCustomerID.Add(transaction);
            }
        }
        return transactionsByCustomerID;
    }
    public List<Transaction> GetAllByType(TransactionType transactionType)
    {
        List<Transaction> transactionsByType = new List<Transaction>();
        foreach (Transaction transaction in transactions)
        {
            if (transaction.TransactionType == transactionType)
            {
                transactionsByType.Add(transaction);
            }
        }
        return transactionsByType;
    }
    public Transaction GetByID(int id)
    {
        Transaction Found = null;
        foreach (Transaction transaction in transactions)
        {
            if (transaction.ID == id)
            {
                Found = transaction;
            }
        }
        return Found;
    }
}
