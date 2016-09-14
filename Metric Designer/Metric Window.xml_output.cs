using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Designer
{
    partial class MainWindow
    {
        private void toXML(string filename)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(filename,settings);
            

            writer.WriteStartDocument();
            writer.WriteStartElement("issues");
            issueNodeParser(ref writer, (IssueTreeNode)editorTree.Nodes[0]);
            writer.WriteEndElement();

            writer.Close();
        }

        private void issueNodeParser(ref XmlWriter writer, IssueTreeNode node, int level = 0)
        {
            foreach(IssueTreeNode n in node.Nodes)
            {
                writer.WriteStartElement("issue");
                writer.WriteAttributeString("type", n.Text);
                writer.WriteAttributeString("level", level.ToString());

                if (n.display)
                {
                    writer.WriteAttributeString("display", "yes");
                }
                else
                {
                    writer.WriteAttributeString("display", "no");
                }

                if (n.useWeight)
                {
                    writer.WriteAttributeString("weight", n.weight.ToString());
                }

                if (n.Nodes.Count > 0)
                {
                    issueNodeParser(ref writer, n, level + 1);
                }
                writer.WriteEndElement();
            }
        }
    }
}
