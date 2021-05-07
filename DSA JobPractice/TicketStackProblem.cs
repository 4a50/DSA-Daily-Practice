using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_JobPractice
{
  class TicketStackProblem
  {
    public Stack<Ticket> TicketStack { get; set; }
    public TicketStackProblem()
    {
      //Given a stack of tickets.  Provide an itenery of the trip.
      TicketStack = new Stack<Ticket>();
      TicketStack.Push(new Ticket("DEN", "SEA"));
      TicketStack.Push(new Ticket("NYO", "ATL"));
      TicketStack.Push(new Ticket("RAP", "DEN"));
      TicketStack.Push(new Ticket("SEA", "NYO"));
    }
    public List<string> SortTickets()
    {
      Dictionary<string, string> ticketDictionary = new Dictionary<string, string>();
      Dictionary<string, string> reverseTicketDictionary = new Dictionary<string, string>();
      List<string> iten = new List<string>();
      bool containsCity = true;
      string curCity = "";
      //Populate HashTables(Dictionaries)
      while (TicketStack.Count > 0)
      {
        Ticket curTicket = TicketStack.Peek();
        TicketStack.Pop();
        ticketDictionary.Add(curTicket.Departure, curTicket.Arrival);
        reverseTicketDictionary.Add(curTicket.Arrival, curTicket.Departure);
      }
      //Find the start city
      foreach (KeyValuePair<string, string> s in ticketDictionary)
      {
        if (!reverseTicketDictionary.ContainsKey(s.Key))
        {
          iten.Add(s.Key);
          curCity = s.Value;
          break;
        }
      }
        while (containsCity)
        {
          iten.Add(curCity);
        containsCity = (ticketDictionary.ContainsKey(curCity));
        if (containsCity) curCity = ticketDictionary[curCity];
        }
      
      return iten;
    }
    string itenereary = "";

    public static void PrintItenerary(List<string> list)
    {
      Console.Write("Start");
      foreach (string s in list)
      {
        Console.Write($" => {s}");
      }
      Console.WriteLine(" => End");
    }
  }

  public class Ticket
  {
    public string Departure { get; set; }
    public string Arrival { get; set; }
    public Ticket() { }
    public Ticket(string dep, string arrive)
    {
      Departure = dep;
      Arrival = arrive;
    }

  }
}


