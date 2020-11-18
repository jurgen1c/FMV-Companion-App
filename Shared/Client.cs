namespace FMV
{
  class Client
  {
    public int ClientId {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}

    public Client()
    {

    }

    public Client(int clientId, string firstName, string lastName)
    {
      this.ClientId = clientId;
      this.FirstName = firstName;
      this.LastName = lastName;
    }
  }
}