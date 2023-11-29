using Store.Structs;

namespace Store
{
    public class DataParser
    {
        public List<UserData> userDataList = new List<UserData>();
        public List<ItemData> itemDataList = new List<ItemData>();
        public List<CustomerCartItem> cartDataList = new List<CustomerCartItem>();
        public List<OrderData> orderDataList = new List<OrderData>();

        public OrderData customerOrderData = new OrderData();

        /// <summary>
        /// DataParser Constructor
        ///     Retrieves User Data List (Gets all users in userData)
        ///     Retrieves Item Data List (Gets all items in itemData)
        ///     Retrieves Order Data List (Retreives all orders in system)
        /// </summary>
        public DataParser()
        {
            RetrieveUserDataList();
            RetrieveItemDataList();
            RetrieveOrderDataList();
        }


        //=======================================================================================================
        //      FILE/DATA READ AND WRITE
        //=======================================================================================================

        //====================userDataList====================
        //====================userDataList====================
        //====================userDataList====================

        /// GET userDataList
        /// userrole,userid,username,password,firstname,lastname,email,phone
        /// userrole: admin=1, Employee=2, Customer=3, Packager=4
        private void RetrieveUserDataList()
        {
            userDataList = File.ReadAllLines("UserData.txt")
                .Where(line => !line.StartsWith("//"))
                .Select(line =>
                {
                    string[] lineParts = line.Split(',');

                    return new UserData(
                        Convert.ToInt32(lineParts[0].Trim()), // UserRole
                        lineParts[1].Trim(), // id
                        lineParts[2].Trim(), // username
                        lineParts[3].Trim(), // password
                        lineParts[4].Trim(), // first name
                        lineParts[5].Trim(), // last name
                        lineParts[6].Trim(), // email
                        lineParts[7].Trim() // phone
                    );
                }).ToList();
        }



        /// Save Modified userDataFile to UserData.txt
        private void SaveUserDataToFile()
        {
            var lines = userDataList.Select(userData =>
            {
                return $"{(int)userData.UserRole}," +
                $"{userData.UserId}," +
                $"{userData.UserName}," +
                $"{userData.Password}," +
                $"{userData.FirstName}," +
                $"{userData.LastName}," +
                $"{userData.Email}," +
                $"{userData.PhoneNumber}";
            });

            File.WriteAllLines("UserData.txt", lines);
            RetrieveUserDataList();
        }



        //====================itemDataList====================
        //====================itemDataList====================
        //====================itemDataList====================

        /// <summary>
        /// Gets itemDataList from ItemData.txt
        /// </summary>
        private void RetrieveItemDataList()
        {
            // ITEM DATA
            itemDataList = File.ReadAllLines("ItemData.txt")
                .Where(line => !line.StartsWith("//"))
                .Select(line =>
                {
                    string[] lineParts = line.Split(',');

                    return new ItemData(
                        Convert.ToInt32(lineParts[0]), // Category
                        lineParts[1].Trim(), // Id
                        lineParts[2].Trim(), // name
                        Convert.ToDouble(lineParts[3]), // price
                        lineParts[4].Trim() // description
                    );
                }).ToList();
        }

        /// <summary>
        /// Saves itemDataList to ItemData.txt
        /// </summary>
        private void SaveItemDataList()
        {
            var lines = itemDataList.Select(itemData =>
            {
                return $"{(int)itemData.itemCategory},{itemData.itemId},{itemData.itemName},{itemData.itemPrice},{itemData.itemDescription}";
            });

            File.WriteAllLines("ItemData.txt", lines);
            RetrieveItemDataList();
        }



        //====================orderDataList====================
        //====================orderDataList====================
        //====================orderDataList====================

        /// <summary>
        /// Gets orderDataList from OrderData.txt
        /// </summary>
        private void RetrieveOrderDataList()
        {
            orderDataList = File.ReadAllLines("OrderData.txt")
                .Where(line => !line.StartsWith("//"))
                .Select(line =>
                {
                    string[] lineParts = line.Split(',');


                    List<CustomerCartItem> tempItems = new List<CustomerCartItem>();

                    for (int i = 11; i < lineParts.Length; i += 2)
                    {
                        tempItems.Add(new CustomerCartItem(Convert.ToInt32(lineParts[i]), Convert.ToInt32(lineParts[i + 1])));
                    }


                    OrderData orderToGet = new OrderData(
                        GetUserDataById(lineParts[0].ToString().Trim()), // UserData
                        Convert.ToInt32(lineParts[1].Trim()), // Id
                        Convert.ToDouble(lineParts[2].Trim()), // price
                        Convert.ToInt32(lineParts[3].Trim()), // quantity
                        Convert.ToBoolean(lineParts[4].Trim()), // ordercomplete
                        Convert.ToBoolean(lineParts[5].Trim()), // isdelivery
                        new PaymentInformation(), // Null Payment information protect user data
                        new ShippingInformation(
                            lineParts[6].Trim(), // Street address
                            lineParts[7].Trim(), // city
                            lineParts[8].Trim(), // state
                            lineParts[9].Trim(), // postcode
                            lineParts[10].Trim() // country
                            ), // ShippingInformation
                        tempItems
                        );

                    return orderToGet;

                }).ToList();
        }

        /// <summary>
        /// Saves orderDataList to OrderData.txt
        /// </summary>
        private void SaveOrderDataList()
        {
            // Prepare the data to be saved as lines
            var linesToWrite = orderDataList.Select(order =>
            {
                // Prepare the order data fields as a comma-separated string
                string orderDataString = $"{order.userData.UserId},{order.orderId},{order.price},{order.quantity},{order.orderComplete},{order.isDelivery}," +
                    $"{order.shippingInformation.streetAddress},{order.shippingInformation.city},{order.shippingInformation.state}," +
                    $"{order.shippingInformation.postCode},{order.shippingInformation.country}";

                // Add the customer cart items data
                foreach (var item in order.customerCartItems)
                {
                    orderDataString += $",{item.itemid},{item.itemQuantity}";
                }

                return orderDataString;
            });

            // Write the data to the file
            File.WriteAllLines("OrderData.txt", linesToWrite);
        }



        //====================cartDataList====================
        //====================cartDataList====================
        //====================cartDataList====================

        /// <summary>
        /// Gets cartDataList from CartData.txt
        /// </summary>
        public void RetrieveCartDataList()
        {
            if (!Program.store.userData.IsValid()) return;

            cartDataList = File.ReadAllLines("CartData.txt")
                .Where(line => !line.StartsWith("//"))
                .Where(line =>
                {
                    string[] lineParts = line.Split(',');
                    return Program.store.userData.UserId.Equals(lineParts[0].Trim());
                })
                .Select(line =>
                {
                    string[] lineParts = line.Split(',');
                    return new CustomerCartItem(Convert.ToInt32(lineParts[1]), Convert.ToInt32(lineParts[2]));
                }).ToList();
        }

        /// <summary>
        /// Saves cartDataList to CartData.txt
        /// </summary>
        public void SaveCartDataList()
        {
            string userIdToReplace = Program.store.userData.UserId;
            var newLines = cartDataList.Select(item =>
            {
                return $"{userIdToReplace},{item.itemid},{item.itemQuantity}";
            });

            // Read the existing lines from the file
            List<string> existingLines = File.ReadAllLines("CartData.txt").ToList();

            // Filter out the lines with the specified userId and replace them
            for (int i = existingLines.Count - 1; i >= 0; i--)
            {
                string[] parts = existingLines[i].Split(',');
                if (parts.Length >= 1 && parts[0] == userIdToReplace)
                {
                    existingLines.RemoveAt(i);
                }
            }

            // Add the new lines to the existing lines
            existingLines.AddRange(newLines);

            // Write the modified lines back to the file
            File.WriteAllLines("CartData.txt", existingLines);

            RetrieveCartDataList();
        }










        //=======================================================================================================
        //      PUBLIC METHODS
        //=======================================================================================================

        //====================USERDATA====================
        //====================USERDATA====================
        //====================USERDATA====================

        /// <summary>
        /// Checks whether Login Credentials are correct and returns UserData struct if correct.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserData CheckLogin(string username, string password)
        {
            UserData userData = userDataList.FirstOrDefault(user => user.UserName.Equals(username) && user.Password.Equals(password));

            if (userData.IsValid()) return userData;
            return new UserData();
        }



        /// <summary>
        /// For Registration, Checks whether username is unique
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckUniqueUsername(string username)
        {
            // Check if any user in the list has the specified username
            bool isUsernameUnique = !userDataList.Any(user => user.UserName.Equals(username));
            return isUsernameUnique;
        }



        /// <summary>
        /// Gets UserData struct if Id exists in list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserData GetUserDataById(string id)
        {
            return userDataList.FirstOrDefault(user => user.UserId.Equals(id));
        }



        /// <summary>
        /// Gets UserData if email exists in list. This is used for Forget Password which would be a more sophisticated process in a real system.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public UserData GetUserDataByEmail(string email)
        {
            return userDataList.FirstOrDefault(user => user.Email.Equals(email));
        }



        /// <summary>
        /// Adds a User to userDataList then writes it to UserData.txt
        /// </summary>
        /// <param name="userData"></param>
        public void AddUser(UserData userData)
        {
            if (userData.IsValid())
            {
                userDataList.Add(userData);
                SaveUserDataToFile();
            }
        }



        /// <summary>
        /// Replaces UserData in userDataList that has been modified and save to UserData.txt
        /// </summary>
        /// <param name="userData"></param>
        public void EditUser(UserData userData)
        {
            if (userData.IsValid())
            {
                // Find the index of the user in the userDataList
                int index = userDataList.FindIndex(u => u.UserId == userData.UserId);

                if (index != -1)
                {
                    userDataList[index] = userData;
                    SaveUserDataToFile();

                    if (Program.store.userData.UserId == userData.UserId)
                    {
                        Program.store.SetUserData(userData);
                    }
                }
            }
        }



        /// <summary>
        /// Delete UserData from userDataList and save to UserData.txt
        /// </summary>
        /// <param name="userData"></param>
        public void DeleteUser(UserData userData)
        {
            if (userData.IsValid())
            {
                // Find the index of the user in the userDataList
                int index = userDataList.FindIndex(u => u.UserId == userData.UserId);

                if (index != -1)
                {
                    userDataList.RemoveAt(index);
                    SaveUserDataToFile();

                    if (Program.store.userData.UserId == userData.UserId)
                    {
                        Program.store.SetUserData(userData);
                    }
                }
            }
        }

        /// <summary>
        /// Generate Unique Id for new user, that doesn't exist in UserData and return it.
        /// </summary>
        /// <returns></returns>
        public string GenerateAutoGeneratedUserId()
        {
            int maxUserId = 10000; // Starting UserId
            if (userDataList.Any())
            {
                maxUserId = userDataList.Select(userData => int.Parse(userData.UserId)).Max();
            }

            return (maxUserId + 1).ToString();
        }



        //====================ITEMDATA====================
        //====================ITEMDATA====================
        //====================ITEMDATA====================

        /// <summary>
        /// Gets ItemData from itemDataList if id is equal and exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ItemData GetItemById(string id)
        {
            ItemData item = itemDataList.FirstOrDefault(item => item.itemId.Equals(id));

            if (item.IsValid()) return item;
            return new ItemData();
        }



        /// <summary>
        /// Generates ItemId that doesn't exist in itemDataList 
        /// </summary>
        /// <returns></returns>
        public string GetAutoGeneratedItemId()
        {
            int firstId = 10001;

            while (itemDataList.Any(item => Convert.ToInt32(item.itemId) == firstId))
            {
                firstId++;
            }

            return firstId.ToString();
        }



        /// <summary>
        /// Adds an item to itemDataList
        /// </summary>
        /// <param name="newItem"></param>
        public void AddItem(ItemData newItem)
        {
            itemDataList.Add(newItem);
            SaveItemDataList();
        }



        /// <summary>
        /// Edits an item in itemDataList
        /// </summary>
        /// <param name="newItem"></param>
        public void EditItem(ItemData newItem)
        {
            if (newItem.IsValid())
            {
                var existingItem = itemDataList.FirstOrDefault(item => item.itemId.Equals(newItem.itemId));

                if (existingItem.IsValid())
                {
                    itemDataList[itemDataList.IndexOf(existingItem)] = newItem;
                }
            }
            SaveItemDataList();
        }



        /// <summary>
        /// Deletes Item in itemDataList that exists
        /// </summary>
        /// <param name="itemIdToDelete"></param>
        public void DeleteItemById(string itemIdToDelete)
        {
            var existingItem = itemDataList.FirstOrDefault(item => item.itemId.Equals(itemIdToDelete));

            if (existingItem.IsValid())
            {
                itemDataList.Remove(existingItem);
                SaveItemDataList();
            }
        }



        //====================CARTDATA====================
        //====================CARTDATA====================
        //====================CARTDATA====================

        /// <summary>
        /// Removes Item From Cart
        /// </summary>
        /// <param name="id"></param>
        public void RemoveCartItem(int id)
        {
            for (int i = 0; i < cartDataList.Count; i++)
            {
                if (cartDataList[i].itemid == id)
                {
                    cartDataList.RemoveAt(i);
                }
            }
            SaveCartDataList();
        }



        /// <summary>
        /// Adds Item Quantity to Customer Cart
        /// </summary>
        /// <param name="id"></param>
        public void AddCartItemQuantity(int id)
        {
            for (int i = 0; i < cartDataList.Count; i++)
            {
                if (cartDataList[i].itemid == id)
                {
                    CustomerCartItem item = new CustomerCartItem(cartDataList[i].itemid, cartDataList[i].itemQuantity + 1);
                    cartDataList[i] = item;
                }
            }
            SaveCartDataList();
        }



        /// <summary>
        /// Reduces quantity by of item in Cart and remove it if 0
        /// </summary>
        /// <param name="id"></param>
        public void MinusCartItemQuantity(int id)
        {
            for (int i = 0; i < cartDataList.Count; i++)
            {
                if (cartDataList[i].itemid == id)
                {
                    if (cartDataList[i].itemQuantity > 1)
                    {
                        CustomerCartItem item = new CustomerCartItem(cartDataList[i].itemid, cartDataList[i].itemQuantity - 1);
                        cartDataList[i] = item;
                    }
                    else
                    {
                        cartDataList.RemoveAt(i);
                    }
                }
            }
            SaveCartDataList();
        }

        /// <summary>
        /// Clears Cart of all Items
        /// </summary>
        public void ClearCart()
        {
            cartDataList.Clear();
            SaveCartDataList();
        }



        //====================ORDERDATA====================
        //====================ORDERDATA====================
        //====================ORDERDATA====================

        /// <summary>
        /// Adds Order to orderDataList and writes to OrderData.txt
        /// </summary>
        /// <param name="newOrder"></param>
        public void AddOrder(OrderData newOrder)
        {
            orderDataList.Add(newOrder);
            SaveOrderDataList();
        }



        /// <summary>
        /// Generated Unique Order Id 
        /// </summary>
        /// <returns></returns>
        public int GetAutoGeneratedOrderId()
        {
            int firstId = 100000000;

            while (orderDataList.Any(order => Convert.ToInt32(order.orderId) == firstId))
            {
                firstId++;
            }

            return firstId;
        }



        /// <summary>
        /// Gets OrderData by orderId
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public OrderData GetOrderData(int orderId)
        {
            return orderDataList.FirstOrDefault(item => item.orderId.Equals(orderId));
        }



        /// <summary>
        /// Toggles Whether the Order was complete or not
        /// </summary>
        /// <param name="orderId"></param>
        public void ToggleOrderComplete(int orderId)
        {
            int index = orderDataList.FindIndex(item => item.orderId.Equals(orderId));

            if (index >= 0)
            {
                OrderData tempOrder = orderDataList[index];
                tempOrder.orderComplete = !tempOrder.orderComplete;
                orderDataList[index] = tempOrder;

                SaveOrderDataList();
            }
        }



        /// <summary>
        /// Removes Order from orderDataList and writes to OrderData.txt
        /// </summary>
        /// <param name="id"></param>
        public void RemoveOrder(int id)
        {
            for (int i = 0; i < orderDataList.Count; i++)
            {
                if (orderDataList[i].orderId == id)
                {
                    orderDataList.RemoveAt(i);
                }
            }
            SaveOrderDataList();
        }

        //====================CUSTOMERORDERDATA====================
        //====================CUSTOMERORDERDATA====================
        //====================CUSTOMERORDERDATA====================

        /// <summary>
        /// Sets customerOrderData (For customer only)
        /// </summary>
        /// <param name="orderData"></param>
        public void SetCustomerOrderData(OrderData orderData)
        {
            this.customerOrderData = orderData;
        }

        /// <summary>
        /// Gets customerOrderData (For customer only)
        /// </summary>
        /// <returns></returns>
        public OrderData GetCustomerOrderData()
        {
            return this.customerOrderData;
        }
    }
}
