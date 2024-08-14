using System;
using Spectre.Console;

namespace Master_DotDevToys
{
    public static class Viewer
    {
        public static int Count = 0;
        public static void Snapshot<T>(T obj, string? Label = null, 
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0) 
        {
            Type type = obj.GetType();

            string s = $"{Count} {type.FullName}/{memberName}:{sourceLineNumber}";
            Tree tree = new(Label == null ? s : $"{s} - {Label}");
            

            foreach (var item in type.GetProperties())
            {
                TreeNode node = tree.AddNode($"Property: {item.Name} - {item.PropertyType.Name}");
                node.AddNode(item.GetValue(obj).ToString());
            }
            foreach (var item in type.GetFields())
            {
                TreeNode node = tree.AddNode($"Field: {item.Name} - {item.FieldType.Name}");
                node.AddNode(item.GetValue(obj).ToString());
            }
            

            AnsiConsole.Write(tree);
            Count++;
        }
    }
}