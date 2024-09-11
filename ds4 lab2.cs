namespace lab2:
{
    class program
    {
        static void Main(string[] args)
        {
            Client client = new Client
            client.firstName + "Michael";
            client.lastName = "Portela";
            client.age = 25;
            client.id = 1;

            console.WriteLine(client.getFullName());
        }
    }

    public int id { get; set;}
    public string firstName { get; set; }
    public string lastName { get; set; }
    public ushort age { get; set; }

    public string getFullName()
    {
        return $"{firstName} {lastName}";
    }


}