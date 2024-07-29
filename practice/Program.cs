string option;

Console.WriteLine("Welcome to the Console Calculator!");
Console.WriteLine("You can perform basic arithmetic operations.");
Console.WriteLine("Choose an option from the menu to get started.");

Console.WriteLine();

Console.WriteLine("Menu:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exit");
Console.Write("Select an option: ");
option = Console.ReadLine();

string num1;
string num2;
string menu;
string ans;
int op;
bool isValidOption;
bool isValidNum1;
bool isValidNum2;
int number1;
int number2;

isValidOption = int.TryParse(option, out op);
while (true)
{
    if (isValidOption) {
        
        if (op == 1)
    {
        Console.Write("Enter the first number: ");
        num1 =Console.ReadLine();
        Console.Write("Enter the second number: ");
        num2 = Console.ReadLine();
            isValidNum1 = int.TryParse(num1, out number1);
            isValidNum2 = int.TryParse(num2, out number2);
        if(isValidNum1 && isValidNum2) { 
                Console.WriteLine("The result of the addition is: " + (number1 + number2));

                Console.Write("Do you want to do another one? ");
                ans = Convert.ToString(Console.ReadLine());

                if (ans == "yes" || ans == "YES")
                {
                    Console.Write("Do you need to see the menu again? ");
                    menu = Convert.ToString(Console.ReadLine());
                    if (menu == "yes" || menu == "YES")
                    {
                        Console.WriteLine("Menu:");
                        Console.WriteLine("1. Addition");
                        Console.WriteLine("2. Subtraction");
                        Console.WriteLine("3. Multiplication");
                        Console.WriteLine("4. Division");
                        Console.WriteLine("5. Exit");
                        Console.Write("Select an option: ");
                        option = Console.ReadLine();
                        isValidOption = int.TryParse(option, out op);
                    }
                    else
                    {
                        Console.Write("Select an option: ");
                        option = Console.ReadLine();
                        isValidOption = int.TryParse(option, out op);
                    }

                }

                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Please reenter");
                Console.Write("Enter the first number: ");
                num1 = Console.ReadLine();
                Console.Write("Enter the second number: ");
                num2 = Console.ReadLine();
                isValidNum1 = int.TryParse(num1, out number1);
                isValidNum2 = int.TryParse(num2, out number2);
            }
       


    }
    else if (op == 2)
    {
        Console.Write("Enter the first number: ");
        num1 = Console.ReadLine();
        Console.Write("Enter the second number: ");
        num2 = Console.ReadLine();
            isValidNum1 = int.TryParse(num1, out number1);
            isValidNum2 = int.TryParse(num2, out number2);

            if(isValidNum1 && isValidNum2) {  
        Console.WriteLine("The result of the subtraction is: " + (number1 - number2));
        Console.Write("Do you want to do antoher one? ");
        ans = Convert.ToString(Console.ReadLine());
        if (ans == "yes" || ans == "YES")
        {
            Console.Write("Do you need to see the menu again? ");
            menu = Convert.ToString(Console.ReadLine());
            if (menu == "yes" || menu == "YES")
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                option = Console.ReadLine();
                isValidOption = int.TryParse(option, out op);
                
            }
            else
            {
                Console.Write("Select an option: ");
    
                option = Console.ReadLine();
                isValidOption = int.TryParse(option, out op);
                    }

        }

        else
        {
            break;
        } 
            
            
            }
            else
            {
                Console.WriteLine("Please reenter");
                Console.Write("Enter the first number: ");
                num1 = Console.ReadLine();
                Console.Write("Enter the second number: ");
                num2 = Console.ReadLine();
                isValidNum1 = int.TryParse(num1, out number1);
                isValidNum2 = int.TryParse(num2, out number2);
            }




        }
    else if (op == 3)
    {
        Console.Write("Enter the first number: ");
        num1 = Console.ReadLine();
        Console.Write("Enter the second number: ");
        num2 = Console.ReadLine();
            isValidNum1 = int.TryParse(num1, out number1);
            isValidNum2 = int.TryParse(num2, out number2);

    if (isValidNum1 && isValidNum2) {
                
        Console.WriteLine("The result of the multiplication is: " + (number1 * number2));
        Console.Write("Do you want to do antoher one? ");
        ans = Convert.ToString(Console.ReadLine());
        if (ans == "yes" || ans == "YES")
        {
            Console.Write("Do you need to see the menu again? ");
            menu = Convert.ToString(Console.ReadLine());
            if (menu == "yes" || menu == "YES")
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                option = Console.ReadLine();
                isValidOption = int.TryParse(option, out op);
            }
            else
            {
                Console.Write("Select an option: ");
                        option = Console.ReadLine();
                        isValidOption = int.TryParse(option, out op);
                    }

        }

        else
        {
            break;
        } 
            
          }

            else
            {
                Console.WriteLine("Please reenter");
                Console.Write("Enter the first number: ");
                num1 = Console.ReadLine();
                Console.Write("Enter the second number: ");
                num2 = Console.ReadLine();
                isValidNum1 = int.TryParse(num1, out number1);
                isValidNum2 = int.TryParse(num2, out number2);
            }


        }
    else if (op == 4)
    {
        Console.Write("Enter the first number: ");
        num1 = Console.ReadLine();
        Console.Write("Enter the second number: ");
        num2 = Console.ReadLine();
            isValidNum1 = int.TryParse(num1, out number1);
            isValidNum2 = int.TryParse(num2, out number2);
        if(isValidNum1 && isValidNum2) 
            {      
        Console.WriteLine("The result of the division is: " + (number1 / number2));
        Console.Write("Do you want to do antoher one? ");
        ans = Convert.ToString(Console.ReadLine());
        if (ans == "yes" || ans == "YES")
        {
            Console.Write("Do you need to see the menu again? ");
            menu = Convert.ToString(Console.ReadLine());
            if (menu == "yes" || menu == "YES")
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                option = Console.ReadLine();
                isValidOption = int.TryParse(option, out op);
            }
            else
            {
                Console.Write("Select an option: ");
                     option = Console.ReadLine();
                    isValidOption = int.TryParse(option, out op);
                    
                    }

        }

        else
        {

                    break;
        }
}
            else
            {
                Console.WriteLine("Please reenter");
                Console.Write("Enter the first number: ");
                num1 = Console.ReadLine();
                Console.Write("Enter the second number: ");
                num2 = Console.ReadLine();
                isValidNum1 = int.TryParse(num1, out number1);
                isValidNum2 = int.TryParse(num2, out number2);
            }

        }
    else
    {
            Console.WriteLine("You have succesfully exited the applicaiton");
        break;
    } 
    }
    else
    {
        
        Console.WriteLine("Not a valid entry, reenter: ");
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
        option = Console.ReadLine();
        isValidOption = int.TryParse(option, out op);

    }
}
