//Question1: Copying and Array.
                int[] originalArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] copiedArray = new int[originalArray.Length];
                for (int i = 0; i < originalArray.Length; i++)
                {
                    copiedArray[i] = originalArray[i];
                }
                Console.WriteLine("Original Array:");
                for (int i = 0; i < originalArray.Length; i++)
                {
                    Console.Write(originalArray[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Copied Array:");
                for (int i = 0; i < copiedArray.Length; i++)
                {
                    Console.Write(copiedArray[i] + " ");
                }
                Console.WriteLine();
                
//Question2:  

//Question3: 
                
                    int startNum = 10;
                    int endNum = 50;
                    int[] primes = FindPrimesInRange(startNum, endNum);
                
                    Console.WriteLine("Prime numbers between {0} and {1}:", startNum, endNum);
                    foreach (int prime in primes)
                    {
                        Console.Write(prime + " ");
                    }

                    static int[] FindPrimesInRange(int startNum, int endNum)
                    {
                        int[] primesTemp = new int[endNum - startNum + 1];
                        int count = 0;
                        for (int num = startNum; num <= endNum; num++)
                        {
                            if (IsPrime(num))
                            {
                                primesTemp[count] = num;
                                count++;
                            }
                        }

                        int[] primes = new int[count];
                        for (int i = 0; i < count; i++)
                        {
                            primes[i] = primesTemp[i];
                        }

                        return primes;
                    }

                    static bool IsPrime(int number)
                    {
                        if (number <= 1)
                        {
                            return false;
                        }

                        for (int i = 2; i <= Math.Sqrt(number); i++)
                        {
                            if (number % i == 0)
                            {
                                return false;
                            }
                        }

                        return true;
                    }
//Question4:
                   
                    Console.WriteLine("Enter the array elements (space separated):");
                    int[] array1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                    Console.WriteLine("Enter the number of rotations:");
                    int k = int.Parse(Console.ReadLine());

                    int n = array.Length;
                    int[] sumArray = new int[n];

                    for (int r = 1; r <= k; r++)
                    {
                        int[] rotatedArray = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            rotatedArray[(i + r) % n] = array1[i];
                        }

                        for (int i = 0; i < n; i++)
                        {
                            sumArray[i] += rotatedArray[i];
                        }

                        Console.WriteLine($"Rotated array after {r} rotations: {string.Join(" ", rotatedArray)}");
                    }
                    Console.WriteLine($"Sum array: {string.Join(" ", sumArray)}");

//Question5:  
                Console.WriteLine("Enter the array elements (space separated):");
                int[] array2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int maxLength = 0;
                int maxStartIndex = 0;
                int currentLength = 1;
                for (int i = 1; i < array2.Length; i++)
                {
                    if (array2[i] == array2[i - 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            maxStartIndex = i - currentLength;
                        }
                        currentLength = 1;
                    }
                }
                
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = array2.Length - currentLength;
                }
                
                Console.WriteLine("Longest sequence of equal elements:");
                for (int i = 0; i < maxLength; i++)
                {
                    Console.Write(array2[maxStartIndex + i] + " ");
                }

//Question6:   

                            Console.WriteLine("Enter the array elements (space separated):");
                            int[] array3= Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                            
                            int mostFrequentNumber = array3[0];
                            int maxFrequency = 1;
                            
                            for (int i = 0; i < array3.Length; i++)
                            {
                                int currentNumber = array3[i];
                                int currentFrequency = 0;
                            
                                for (int j = 0; j < array3.Length; j++)
                                {
                                    if (array3[j] == currentNumber)
                                    {
                                        currentFrequency++;
                                    }
                                }
                            
                                if (currentFrequency > maxFrequency || (currentFrequency == maxFrequency && Array.IndexOf(array3, currentNumber) < Array.IndexOf(array, mostFrequentNumber)))
                                {
                                    maxFrequency = currentFrequency;
                                    mostFrequentNumber = currentNumber;
                                }
                            }
                            
                            Console.WriteLine($"The number {mostFrequentNumber} is the most frequent (occurs {maxFrequency} times).");

//Question1: Strings
                             // --------Using char Array---------
                             Console.WriteLine("Enter a string to reverse:");
                             string input = Console.ReadLine();
                            
                             char[] charArray = input.ToCharArray();
                            
                             Array.Reverse(charArray);
                        
                             string reversedString = new string(charArray);
                        
                             Console.WriteLine("Reversed string (using char array):");
                             Console.WriteLine(reversedString);
                            
                            //-------Using a for Loop---------
                             Console.WriteLine("Enter a string to reverse:");
                             string input = Console.ReadLine();
                            
                             Console.WriteLine("Reversed string (using for loop):");
                             for (int i = input.Length - 1; i >= 0; i--)
                             {
                                 Console.Write(input[i]);
                             }
                             Console.WriteLine();
//Question2:
                             Console.WriteLine("Enter a sentence:");
                             string input = Console.ReadLine();

                             char[] separators = new char[] { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };

                             string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                             char[] inputArray = input.ToCharArray();
                             string[] separatorsArray = new string[inputArray.Length];

                             int wordIndex = 0;
                             for (int i = 0; i < inputArray.Length; i++)
                             {
                                 if (Array.IndexOf(separators, inputArray[i]) >= 0)
                                 {
                                     separatorsArray[i] = inputArray[i].ToString();
                                 }
                                 else if (wordIndex < words.Length)
                                 {
                                     separatorsArray[i] = words[wordIndex];
                                     wordIndex++;
                                 }
                             }

                             Array.Reverse(words);

                             wordIndex = 0;
                             for (int i = 0; i < separatorsArray.Length; i++)
                             {
                                 if (!string.IsNullOrEmpty(separatorsArray[i]) && Array.IndexOf(separators, separatorsArray[i][0]) == -1)
                                 {
                                     separatorsArray[i] = words[wordIndex];
                                     wordIndex++;
                                 }
                             }

                             Console.WriteLine("Reversed sentence:");
                             Console.WriteLine(string.Join("", separatorsArray));
                
                
//Question3: 
                            Console.WriteLine("Enter the text:");
                            string input = Console.ReadLine();
                            
                            char[] separators = new char[] { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };
                            
                            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            string[] uniquePalindromes = new string[words.Length];
                            int palindromeCount = 0;
                            
                            foreach (string word in words)
                            {
                                bool isPalindrome = true;
                                int length = word.Length;
                                for (int i = 0; i < length / 2; i++)
                                {
                                    if (char.ToLower(word[i]) != char.ToLower(word[length - 1 - i]))
                                    {
                                        isPalindrome = false;
                                        break;
                                    }
                                }
                            
                                if (isPalindrome)
                                {
                                    bool isUnique = true;
                                    for (int i = 0; i < palindromeCount; i++)
                                    {
                                        if (string.Equals(uniquePalindromes[i], word, StringComparison.OrdinalIgnoreCase))
                                        {
                                            isUnique = false;
                                            break;
                                        }
                                    }
                            
                                    if (isUnique)
                                    {
                                        uniquePalindromes[palindromeCount] = word;
                                        palindromeCount++;
                                    }
                                }
                            }
                            
                            Array.Resize(ref uniquePalindromes, palindromeCount);
                            Array.Sort(uniquePalindromes, StringComparer.OrdinalIgnoreCase);
                            
                            Console.WriteLine("Unique palindromes:");
                            Console.WriteLine(string.Join(", ", uniquePalindromes));

//Question4:
                            Console.WriteLine("Enter a URL:");
                            string input = Console.ReadLine();
                            string protocol = "";
                            string server = "";
                            string resource = "";
                            int protocolIndex = input.IndexOf("://");
                            if (protocolIndex != -1)
                            {
                                protocol = input.Substring(0, protocolIndex);
                                input = input.Substring(protocolIndex + 3);
                            }
                            int resourceIndex = input.IndexOf("/");
                            if (resourceIndex != -1)
                            {
                                server = input.Substring(0, resourceIndex);
                                resource = input.Substring(resourceIndex + 1);
                            }
                            else
                            {
                                server = input;
                            }

                            Console.WriteLine($"[protocol] = \"{protocol}\"");
                            Console.WriteLine($"[server] = \"{server}\"");
                            Console.WriteLine($"[resource] = \"{resource}\"");
                            