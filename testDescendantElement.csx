using System.Xml.Linq;

XElement xmlTree = new XElement("Root",
    new XAttribute("Att1", "AttributeContent"),
    new XElement("Child",
        new XText("Some text"),
        new XElement("GrandChild", "element content"),
    new XElement("ChildSibing",  
        new XText("Some text"),  
        new XElement("GrandChildSibing", "element content"),
        new XElement("Chenz", "element content chen")
)));

foreach (XElement el in xmlTree.DescendantsAndSelf())
    Console.WriteLine(el.Name);

// output: 
// Root
// Child
// GrandChild
// ChildSibing
// GrandChildSibing
// Chenz