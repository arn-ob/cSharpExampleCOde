using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace learnFormEvent
{
    /// <summary>
    /// this code is at professional C# 2008 page no : 263
    /// Part name Read-Only 
    /// Selection name : Queues
    /// </summary>

    public class Document
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
        }

        private string content;
        public string Content
        {
            get
            {
                return content;
            }
        }

        public Document(string title, string content)
        {
            this.content = content;
            this.title = title;
        }

    }




    public class DocumentManager
    {
        private readonly Queue<Document> documentQueue = new Queue<Document>();
        public void addDocument(Document doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public Document GetDocument()
        {
            Document doc = null;
            lock(this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }

        public bool IsDocumentAvalable
        {
            get
            {
                return documentQueue.Count > 0;
            }
        }

    }




    public class ProcessDocument
    {
        public static void Start(DocumentManager dm)
        {
            new Thread(new ProcessDocument(dm).Run).Start();
        }


        private DocumentManager documentManager;

        protected ProcessDocument(DocumentManager dm)
        {
            documentManager = dm;
        }

        protected void Run()
        {
            while (true)
            {
                if(documentManager.IsDocumentAvalable){
                    Document doc = documentManager.GetDocument();
                    Console.WriteLine("Processing document {0}", doc.Title);
                }
                Thread.Sleep(new Random().Next(20));
            }
        }
    }

     class QueuesLearnDocumentManager
    {
         static void Main()
         {
             DocumentManager dm = new DocumentManager();

             ProcessDocument.Start(dm);

             //create document and add then to the DocumentManager

             for (int i = 0; i < 10; i++)
             {
                 Document doc = new Document("Doc" + i.ToString(), "content");
                 dm.addDocument(doc);
                 Console.WriteLine("Added document {0}", doc.Title);
                 Thread.Sleep(new Random().Next(20));
             }
         }
    }
}
