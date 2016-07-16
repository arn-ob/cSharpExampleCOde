using System;
using System.Collections.Generic;


namespace learnFormEvent
{
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

       private byte priority;
       public byte Priority
       {
           get
           {
               return priority;
           }
       }

       public Document(string title, string content, byte property)
       {
           this.title = title;
           this.content = content;
           this.priority = property;
       }

       
    }

    
#region Main Priority Document Managing  Class 
    /// <summary>
    /// That all priority will manage here 
    /// send here a doc name and priority
   /// </summary>
  
   public class PriorityDocumentManager
   {
       private readonly LinkedList<Document> documentList;

       private readonly List<LinkedListNode<Document>> priorityNodes;

       public PriorityDocumentManager()
       {
           documentList = new LinkedList<Document>();
           priorityNodes = new List<LinkedListNode<Document>>(10);

           for (int i = 0; i < 10; i++)
           {
               priorityNodes.Add(new LinkedListNode<Document>(null));
           }
        }

   
       public void AddDocument(Document d)
       {
           if (d == null)
           {
               throw new ArgumentNullException("d");
               //AddDocumentToPriorityNode(d, d.Priority);
           }
           AddDocumentToPriorityNode(d, d.Priority);
           
       }

      
       private void AddDocumentToPriorityNode(Document doc, int priority)
       {
           if (priority > 9 || priority < 0)
           {
               //throw new ArgumentException("Priority must be between 0 and 9");
               Console.WriteLine("Priority {0} Not working in range ", priority);
               documentList.Remove(priorityNodes[priority]);
            //   priorityNodes[doc.Priority].Next;
           }
           if (priorityNodes[priority].Value == null)
           {
               priority--;
               if (priority > 0)
               {
                   AddDocumentToPriorityNode(doc, priority);
               }
               // now no priority node exists with the same priority or lower add the new document to the end   
               else
               {
                   documentList.AddLast(doc);
                   priorityNodes[doc.Priority] = documentList.Last;

               }
               return;
           }
           else // a priority node exists
           {
               LinkedListNode<Document> priNode = priorityNodes[priority];
               if (priority == doc.Priority)
               {
                   documentList.AddAfter(priNode, doc);
                   // set the priority node to the last document with the same priority
                   priorityNodes[doc.Priority] = priNode.Next;
               }
               else
                   // only priority node with a lower priority exists
               {
                   LinkedListNode<Document> firstPrioNode = priNode;

                   while (firstPrioNode.Previous != null && firstPrioNode.Previous.Value.Priority == priNode.Value.Priority)
                   {
                       firstPrioNode = priNode.Previous;
                   }

                   documentList.AddBefore(firstPrioNode, doc);
                   priorityNodes[doc.Priority] = firstPrioNode.Previous; 
               }

           }
        }

       public void DisplayAllNodes()
       {
           foreach (Document doc in documentList)
           {
               Console.WriteLine("Priority : {0} , Title {1} ", doc.Priority, doc.Title);
           }
       }

       public Document GetDocument()
       {
           Document doc = documentList.First.Value;
           documentList.RemoveFirst();
           return doc;
       }

    }
#endregion

    public class DecumentMain
   {
       static void Main()
       {
           PriorityDocumentManager pdm = new PriorityDocumentManager();

           pdm.AddDocument(new Document("one", "simple", 50));
           pdm.AddDocument(new Document("two", "simple", 3));
           pdm.AddDocument(new Document("three", "simple", 4));
           pdm.AddDocument(new Document("four", "simple", 1));
           pdm.AddDocument(new Document("five", "simple", 6));
           pdm.AddDocument(new Document("six", "simple", 9));
           pdm.DisplayAllNodes();
           Console.ReadLine();
       }
   }

}
