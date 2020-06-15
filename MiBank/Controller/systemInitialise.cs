using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Dynamic;

namespace MiBank {
    public class systemInitialise {

        public int LoginAttemps; 
        public double currentMenuLevel;
        public navigations currMenu;
        public Customer customer;
        List<navigations> allMenus = new List<navigations>();
        public apiManager api = new apiManager();
        public inputValidations validations = new inputValidations();
        public dataBaseManager dbManager = new dataBaseManager();

        public systemInitialise () {
            InstantiateMenus();
            dbManager.CheckTables();
          
        }

        void InstantiateMenus() {
          
            allMenus.Add(new menuLogin());
            allMenus.Add(new menuMain());
            allMenus.Add(new menuDeposit());
            allMenus.Add(new menuWithdrawal());
            allMenus.Add(new menuStatement());
            this.currMenu = allMenus[0];
        }


        public Boolean ChecktablesAndContent() {

            return true;
        }

        public void SetMenu (double level){
            foreach (navigations menu in allMenus) {
                if (menu.level == level) {
                    this.currMenu = menu;
                }
            }
            
           
        }


    } 
            
        

    
}
