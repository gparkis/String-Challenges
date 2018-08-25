using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace String_Reversal
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            // 1. REVERSE THE NAME

            string name = "Grant Parkis";

            for (int i = name.Length-1; i >= 0; i--)
            {
                resultLbl.Text += name[i];
            }
           

            // 2. REVERSE THE SEQUENCE
            string names = "Grant,Max,Jessie,Noah";
            string[] namesSplit = names.Split(',');
            string result = "";
            for (int i = namesSplit.Length -1; i >= 0; i--)
            {
                result += namesSplit[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1); // removing the , at the end 
            resultLbl.Text = result;
             

            // 3.USE THE SEQUENCE TO CREATE ASCII ART

            string names = "Grant,Max,Jessie,Noah";
            string[] nameSplit = names.Split(',');
            string result = "";
            for (int i = 0; i < nameSplit.Length; i++)
            {
                int padLeft = (14 - nameSplit[i].Length) / 2;
                string temp = nameSplit[i].PadLeft(nameSplit[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";
            }
            resultLbl.Text = result;
            */

            // 4.SOLVE THE PUZZLE

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            string removeme = "remove-me";
            int index = puzzle.IndexOf(removeme);
            puzzle = puzzle.Remove(index, removeme.Length);

            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');

            puzzle = puzzle.Remove(0, 1); // index 0 for 1 char
            puzzle = puzzle.Insert(0, "N");

            resultLbl.Text = puzzle;
        }
    }
}