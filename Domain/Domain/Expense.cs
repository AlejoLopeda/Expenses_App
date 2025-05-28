namespace Domain
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Name { get; set; } // Nombre del gasto
        public decimal Cost { get; set; } // Costo del gasto
        public string Power { get; set; } // Poder
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}