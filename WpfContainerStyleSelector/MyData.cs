using System;
using System.Collections.Generic;

namespace WpfContainerStyleSelector
{
    class MyData
    {
        public enum ItemType { Bool, Int, String };
        public ItemType Type { get; }

        public bool BoolValue { get; set; }
        public int IntValue { get; set; }
        public string StringValue { get; set; }

        public string Value =>
            Type switch
            {
                ItemType.Bool => BoolValue.ToString(),
                ItemType.Int => IntValue.ToString(),
                ItemType.String => StringValue,
                _ => throw new NotSupportedException(Type.ToString()),
            };

        private MyData(bool b)
        {
            Type = ItemType.Bool;
            BoolValue = b;
        }
        private MyData(int i)
        {
            Type = ItemType.Int;
            IntValue = i;
        }
        private MyData(string s)
        {
            Type = ItemType.String;
            StringValue = s ?? "";
        }

        // ◆下記、雑多な並びのリストがグルーピングされて表示される
        public static List<MyData> Items =>
            new List<MyData>()
            {
                new MyData(false),
                new MyData(true),
                new MyData(123),
                new MyData("Hello"),
                new MyData(null),
                new MyData(4321),
                new MyData("こんにちわ"),
                new MyData(false),
                new MyData(0),
            };

        public override string ToString() => Value;
    }
}
