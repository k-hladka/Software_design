using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Console.Classes
{
    public sealed class Field   //This class implements 'Singleton' pattern
    {
        private static Field? instance;
        private string StringField { get; set; }
        private Field(char[] symbols) {
            this.StringField = ChangeField(symbols);
        }
        public static Field GetField(char[] symbols)
        {
            if (instance == null)
                instance = new Field(symbols);
            else
                instance.StringField = instance.ChangeField(symbols);
            return instance;
        }
        private string ChangeField(char[] symbols)
        {
            StringBuilder StringBuilderField = new StringBuilder();
            StringBuilderField.Capacity = 10;

            StringBuilderField.Append("\n");
            for (int i = 0; i < symbols.Length; i++)
            {
                StringBuilderField.Append($" {symbols[i]} ");
                if (i != 2 && i != 5 && i != 8)
                    StringBuilderField.Append("|");
                if (i == 2 || i == 5)
                    StringBuilderField.Append("\n---+---+---\n");
            }
            StringBuilderField.Append("\n");

            string resultStringField = StringBuilderField.ToString();
            return resultStringField;
        }
        public override string ToString()
        {
            return this.StringField;
        }
    }
}
