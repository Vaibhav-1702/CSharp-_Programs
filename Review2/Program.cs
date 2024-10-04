using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review2
{
    public interface IUser
    {
        
        string Name { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Pincode { get; set; }

        void DisplayUser();
    }


    class User : IUser
    {
        
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }

      
        public User(string name, string phoneNumber, string email, string address, string pincode)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Pincode = pincode;
        }

        
        public void DisplayUser()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Pincode: {Pincode}");
        }
    }


    class UserManager
    {
        private List<IUser> users = new List<IUser>();

        
        public void CreateUser(string name, string phoneNumber, string email, string address, string pincode)
        {
            IUser newUser = new User(name, phoneNumber, email, address, pincode);
            users.Add(newUser);
            Console.WriteLine("User created successfully.");
        }

        
        public void ReadUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users available.");
                return;
            }

            Console.WriteLine("List of users:");
            foreach (var user in users)
            {
                user.DisplayUser(); 
                Console.WriteLine();
            }
        }

        
        public void UpdateUser(string name, string newPhoneNumber, string newEmail, string newAddress, string newPincode)
        {
            IUser user = users.Find(u => u.Name == name);

            if (user != null)
            {
                user.PhoneNumber = newPhoneNumber;
                user.Email = newEmail;
                user.Address = newAddress;
                user.Pincode = newPincode;
                Console.WriteLine("User updated successfully.");
            }
            else
            {
                throw new UserNotFoundException($"User with name '{name}' not found.");
            }
        }

        
        public void DeleteUser(string name)
        {
            IUser user = users.Find(u => u.Name == name);

            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                throw new UserNotFoundException($"User with name '{name}' not found.");
            }
        }
    }


    class Program
    {
        static void Main()
        {
            UserManager userManager = new UserManager();

            
            userManager.CreateUser("Vaibhav", "1234567890", "Vaibhav.koli30@gamil.com", "Kalbhornagar", "411019");
            userManager.CreateUser("Aditya Deshmukh", "0987654321", "adityaDeshgamil.com", "Akurdi", "411018");

            
            Console.WriteLine("Reading all users:");
            userManager.ReadUsers();

            try
            {
                
                Console.WriteLine("Updating Vaibhav's details...");
                userManager.UpdateUser("Vaibhav Koli", "1112223333", "Vaibhav.koli30@gmail.com", "chinchwad", "111111");
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            Console.WriteLine("Reading all users after update:");
            userManager.ReadUsers();

            try
            {
                
                Console.WriteLine("Deleting Aditya...");
                userManager.DeleteUser("Aditya Deshmukh");
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                
                Console.WriteLine("Trying to delete a non-existing user...");
                userManager.DeleteUser("Non Existent User");
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            
            Console.WriteLine("Reading all users after deletion:");
            userManager.ReadUsers();
        }
    }

    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) : base(message)
        {
        }
    }


}