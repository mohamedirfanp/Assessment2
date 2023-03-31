using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    internal class LicensePlateRegroup
    {
        public void LicensePlate(string dmv_number_plate, int regroup_number)
        {
            string dmv_number_plate_without_underscore = string.Join("", dmv_number_plate.Split('-')).ToUpper();

            string regroup_number_plate = "";
            int count_to_add = 0;
            for (int i = dmv_number_plate_without_underscore.Length - 1; i >= 0; i--)
            {
                if (count_to_add < regroup_number)
                {
                    regroup_number_plate += dmv_number_plate_without_underscore[i];
                    count_to_add++;
                }
                else
                {
                    regroup_number_plate += '-';
                    regroup_number_plate += dmv_number_plate_without_underscore[i];
                    count_to_add = 1;
                }
            }

            string regrouped_license_plate = string.Join("", regroup_number_plate.Reverse());

            Console.WriteLine("The Regrouped License Plate : {0}",regrouped_license_plate);


        }
}
}
