using System;
using System.Collections.Generic;

namespace WpfDataTemplateSelector
{
    class MyData
    {
        public enum ItemType { Bool, Int, String };
        public ItemType Type { get; }

        private readonly bool _boolValue;
        private readonly int _intValue;
        private readonly string _stringValue;

        public string Value =>
            Type switch
            {
                ItemType.Bool => _boolValue.ToString(),
                ItemType.Int => _intValue.ToString(),
                ItemType.String => _stringValue,
                _ => throw new NotSupportedException(Type.ToString()),
            };

        private MyData(bool b)
        {
            Type = ItemType.Bool;
            _boolValue = b;
        }
        private MyData(int i)
        {
            Type = ItemType.Int;
            _intValue = i;
        }
        private MyData(string s)
        {
            Type = ItemType.String;
            _stringValue = s ?? "";
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
