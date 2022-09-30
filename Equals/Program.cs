using Equals.Entities;

Client a = new Client{Name = "Maria", Email = "maria@gmail.com"};
Client b = new Client{Name = "Alex", Email = "alex@gmail.com"};
//b.Email = a.Email;

System.Console.WriteLine(a.Equals(b));
System.Console.WriteLine(a.GetHashCode());
System.Console.WriteLine(b.GetHashCode());