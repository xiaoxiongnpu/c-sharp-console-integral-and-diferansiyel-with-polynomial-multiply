using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EX
{
    class Program
    {
        static double[] differentialCoefficient = new double[3];
        private static int xPower;
        private static int selection;
        private static string polynomialBase;
        private static string favorite_1;

        static void Main(string[] args)
        {

            //explanation string!
            string meet = "Hey!\n";
            string errorText = "(If you can not solve the error please just contact me : +9890---2028)";
            string tryAgain = "Why just you TRY again : ";
            string explanation_01 = "First Please enter you'r Polynomial base ( Like : X , Y , ahfa, Number etc. ) : ";
            string explanation0 = "Good, now please enter you'r Polynomial separate sentence number or the biggest Power number pluse one : ";
            string explanation1 = "Ok, now i understand you'r Polynomial have [ ";
            string explanation1_1 = " ] Separate Sentence.";
            string explanation2 = "Well, now time to enter you'r Polynomial coefficients (like this : 231 owing to you'r power here power is 3 ) : ";
            string explanation3 = "Nice, now if i say right you'r Polynomial is : ";
            string explanation4 = "If you'r Polynomial have any proplem you can restart program or report the bug by contact me : +98990---2028. ";
            string explanation5 = "Else : ";
            string explanation6 = "Now you have to select one of the following actions by enter it's number : ";
            string explanation6_0 = "1.If you want to calculate the Polynomial derivative (differential) enter 1.";
            string explanation6_1 = "2.If you want to calculate the Polynomial integral enter 2.";
            string explanation6_2 = "2.If you want to calculate Polynomial_1 cross Polynomial_2 enter 3.";
            string explanation6_3 = "Now enter you'r selection : ";
            string explanation7 = "Well, you want Polynomial derivative (differential) so it is : ";
            string explanation7_0 = "Perfect, you'r derivative (differential) is ready : ";
            string explanation7_1 = "Well done, now what? (enter you'r number!)";
            string explanation8_0 = "Ok, This is the main answer of you'r integral problem : ";
            string explanation8_1 = "If you want the Simplified form of you'r problem first please enter you'r favorites character or phrase Instead of ( C ) => ( Like (A),(b), alfa or number ) <if you hate ( C ) in integral!> : ";
            string explanation8_2 = "There it is ";
            string explanation8_3 = "( With Maximum Accuracy ) : ";
            string explanation8_4 = "Perfect!";
            Console.Write(meet);
            Console.Write(explanation_01);

            //the polynomialBase variable like X ,Y ,alfa or numbers
            polynomialBase = Console.ReadLine();
            Console.WriteLine("");

            Console.Write(explanation0);

            try
            {
                //the separate sentence number
                //xPower must be public variable

                xPower = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }
            catch (Exception e0)
            {
                Console.Write("Error! : ");
                Console.WriteLine(e0.Message);
                Console.WriteLine(errorText);
                Console.Write(tryAgain);
            }
            //make array in size of xPower
            int[] xPower_array = new int[xPower];
            //returnitive method
            xPower_array = PowerPolynomial(xPower);
            //show user the result
            Console.WriteLine(explanation1 + xPower + explanation1_1);
            Console.WriteLine("");

            Console.WriteLine(explanation2);
            //get the coefficent array in size of xPower (think)
            double[] coefficient = new double[xPower];
            try
            {
                for (int k = 0; k <= (xPower) - 1; k++)
                {
                    //now reading the coefficent
                    coefficient[k] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("");

            }
            catch (Exception e2)
            {
                Console.Write("Error! : ");
                Console.WriteLine(e2.Message);
                Console.WriteLine(errorText);
                Console.Write(tryAgain);
            }

            Console.Write(explanation3);
            Console.Write("[");
            //for showing user the coefficient form bigger to smaller we must do this
            Array.Reverse(coefficient);
            for (int j = (xPower) - 1; j >= 0; j--)
            {
                // show user the how is his/her polynomial

                Console.Write(" + (" + coefficient[j] + ") " + polynomialBase + "^" + xPower_array[j]);
            }
            //make our array like the difault form
            Array.Reverse(coefficient);
            Console.Write(" ] ");
            Console.WriteLine(explanation4);
            Console.WriteLine("");
            Console.WriteLine(explanation5);
            Console.WriteLine("");
            Console.WriteLine(explanation6);
            Console.WriteLine(explanation6_0);
            Console.WriteLine(explanation6_1);
            Console.WriteLine(explanation6_2);
            Console.WriteLine("");
            Console.Write(explanation6_3);

            try
            {
                //now user enter what should happen
                selection = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e3)
            {
                Console.Write("Error! : ");
                Console.WriteLine(e3.Message);
                Console.WriteLine(errorText);
                Console.Write(tryAgain);
            }

            Console.WriteLine("");

            switch (selection)
            {
                case 1:
                    //if his/her select diff
                    //nice part , take a look:
                    //our method will calculate the new coefficient and the return them                
                    coefficient = Differential(coefficient, xPower_array);
                    Console.Write(explanation7_0);
                    Console.Write("[");
                    //if we have polynomial with more than 3 sentence we user eachDiff nariable
                    int eachDiff = (xPower_array.Length) - (coefficient.Length);
                    int[] xPowerDiff = new int[(xPower_array.Length) - (eachDiff)];
                    //now sort the array form smaller to bigger
                    Array.Sort(xPower_array);
                    for (int r = 0; r <= xPowerDiff.Length - 1; r++)
                    {
                        //omit the last block of array to find the true diff
                        xPowerDiff[r] = xPower_array[r];
                    }
                    //now make the array reverse like the defalt form!
                    Array.Reverse(xPowerDiff);

                    for (int l = 0; l <= xPower_array.Length - 2; l++)
                    {
                        // show user his/her diff result
                        Console.Write(" + (" + coefficient[l] + ") " + polynomialBase + "^" + xPowerDiff[l]);
                    }

                    Console.Write(" ] ");
                    Console.Write(" ");
                    Console.WriteLine(explanation7_1);
                    break;

                case 2:
                    /*
                                 !U-S-E-L-E-S-S!
                    double[] coefficientIntegral = new double[xPower];
                    coefficientIntegral = Integral(xPower_array);
                    */
                    //Array.Reverse(coefficient);
                    Array.Reverse(xPower_array);
                    //array to make integral power
                    int[] integralPower = IntegralPower(xPower_array);

                    Console.WriteLine(explanation8_0);
                    Console.WriteLine("");
                    Console.Write("[");

                    for (int k = 0; k <= (coefficient.Length) - 1; k++)
                    {

                        Console.Write(" + (" + coefficient[k] + ")" + "/(" + integralPower[k] + ") " + polynomialBase + "^" + integralPower[k]);

                    }
                    Console.Write(" + C");
                    Console.Write(" ]");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write(explanation8_1);
                    //if user dont like (C) can enter sth that like!
                    try
                    {
                        //the favorit should be charechter cuse i convert to char
                        favorite_1 = Console.ReadLine();
                    }
                    catch (Exception e4)
                    {

                        Console.Write("Error! : ");
                        Console.WriteLine(e4.Message);
                        Console.WriteLine(errorText);
                        Console.Write(tryAgain);

                    }
                    Console.WriteLine("");
                    Console.Write(explanation8_2);
                    Console.WriteLine(explanation8_3);
                    Console.WriteLine("");
                    Console.Write("[");
                    //the array to simple the integral coefficient
                    decimal[] integralAnswer = new decimal[integralPower.Length];

                    for (int k = 0; k <= (coefficient.Length) - 1; k++)
                    {

                        integralAnswer[k] = (decimal)coefficient[k] / integralPower[k];

                        Console.Write(" + (" + integralAnswer[k] + ") " + polynomialBase + "^" + integralPower[k]);

                    }

                    Console.WriteLine(" + " + favorite_1 + " ]");
                    Console.WriteLine("");
                    Console.WriteLine(explanation8_4);
                    Console.WriteLine("");

                    break;

                case 3:
                    //here i try to find what will happen if user wants to find two polynomial coefficients multiply!
                    string explanation9 = "Well please enter you'r second polynomial coefficients ( Note! : if you first entered a 3 sentence polynomial now you must enter just 3 coefficients not more! ) : ";

                    Console.WriteLine(explanation9);

                    double[] coefficient_2 = new double[xPower];
                    int coefficientCrossNum = (int)Math.Pow(xPower, 2);
                    double[] coefficientCross = new double[coefficientCrossNum];

                    for (int a = 0; a <= (coefficient_2.Length) - 1; a++)
                    {
                        coefficient_2[a] = Convert.ToDouble(Console.ReadLine());

                    }
                    coefficientCross = Product(coefficient, coefficient_2);

                    for (int bb = 0; bb <= (coefficientCrossNum) - 1; bb++)
                    {
                        Console.WriteLine(coefficientCross[bb]);
                    }
                    //coefficientCross = Product (coefficient , coefficient_2 );

                    break;

            }





            Console.ReadLine();





        }
        //method to make the polynomial power
        static int[] PowerPolynomial(int powerNum)
        {

            int[] polynomialPower = new int[powerNum];

            for (int i = 0; i <= (polynomialPower.Length) - 1; i++)
            {

                polynomialPower[i] = i;

            }

            return polynomialPower;
        }

        //method to make our diff polynomial coefficient  
        static double[] Differential(double[] coeff, int[] power)
        {

            double[] differentialResalt = new double[(power.Length) - 1];
            double[] powerDiff = new double[(power.Length) - 1];

            Array.Reverse(power);

            for (int i = 0; i <= (differentialResalt.Length) - 1; i++)
            {

                differentialResalt[i] = coeff[i] * power[i];

            }
            return differentialResalt;

        }
        /*
                              !U-S-E-L-E-S-S!
        //integral method
        static double[] Integral(int [] xPower_array_input0) {
            double[] integralCoeff = new double[(xPower_array_input0.Length)];
            for (int i = 0; i <= (xPower_array_input0.Length)-1; i++) {

                integralCoeff [i] = ( xPower_array_input0 [i] ) + 1 ;

            }
            
            return  integralCoeff ;
        }
        */
        //integral power method
        static int[] IntegralPower(int[] xPower_array_input1)
        {
            for (int i = 0; i <= (xPower_array_input1.Length) - 1; i++)
            {

                xPower_array_input1[i] = xPower_array_input1[i] + 1;

            }
            return xPower_array_input1;
        }

        static double[] Product(double[] coefficient_0, double[] coefficient_1)
        {

            int productResaltNum = (int)Math.Pow(coefficient_0.Length, 2);
            double[] productResalt = new double[productResaltNum];

            for (int i = 0; i <= (productResalt.Length) - 1; i++)
            {

                for (int j = 0; j >= (coefficient_0.Length) - 1; j--)
                {

                    productResalt[i] = coefficient_0[j] * coefficient_1[j];

                }

            }
            return productResalt;

        }


    }
}
