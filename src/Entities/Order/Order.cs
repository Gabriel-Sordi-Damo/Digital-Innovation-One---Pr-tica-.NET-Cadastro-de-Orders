


namespace Order
{
    static class IdGenerator
    {
        private static int currentId = 0;

        public static int GenerateId()
        {
            currentId++;
            return currentId;
        }
    }
    class Order
    {

        public int id { get; private set; }
        public bool excluded { get; private set; }
        public string name { get; private set; }
        public float price { get; private set; }

        public Order(string name, float price)
        {
            this.name = name;
            this.price = price;
            this.id = IdGenerator.GenerateId();
        }

        private Order(string name, float price, int id)
        {
            this.name = name;
            this.price = price;
            this.id = id;
        }

        public void DeleteOrder()
        {
            this.excluded = true;
        }

        public Order Copy()
        {
            return new Order(name, price, id);
        }

        public override string ToString()
        {
            string message = @$"
            name: {name}
            price: {price}
            id: {id}
            ";
            return message;
        }

        public void Update(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public static Order GenerateNullOrder()
        {
            return new Order("Null Order", 0, -1);
        }
    }
}