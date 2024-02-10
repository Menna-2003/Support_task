namespace task.Models {
    public class Blog {
        public int Id {
        get; set; }
        public string Name {
        get; set; }
        public string Description {
        get; set; }
        public float price {
        get; set; }
        public int Quantity { get; set; }
        public bool EnableSize { get; set; }

        public Company company { get; set; }

    }
}
