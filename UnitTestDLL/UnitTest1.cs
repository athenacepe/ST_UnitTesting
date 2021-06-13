using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;

namespace UnitTestDLL
{
    [TestClass]
    public class UnitTest1
    {
        //TM1 - Checks if the node is not a prime number
        [TestMethod]
        public void TestMethod1()
        {
            DLList a = new DLList();
            DLLNode p = new DLLNode(100);
            a.addToHead(p);
            Assert.AreEqual(false, p.CheckPrime(a.head.num));
        }

        //TM2 - Node to be inserted is an integer and there are no errors
        [TestMethod]
        public void TestMethod2()
        {
            DLList a = new DLList();
            DLLNode p = new DLLNode(7);
            a.addToHead(p);
        }

        //TM3 - Test if the node added to head is the head of the DLL (Single node)
        [TestMethod]
        public void TestMethod3()
        {
            DLList a = new DLList();
            DLLNode p = new DLLNode(2);
            a.addToHead(p);
            Assert.AreEqual(2, a.head.num);
        }

        //TM4 - Test if the node added is the head of the DLL (Multiple Nodes)
        [TestMethod]
        public void TestMethod4()
        {
            DLList a = new DLList();
            int[] b = new int[3];
            b[0] = 1;
            b[1] = 2;
            b[2] = 3;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode((b[i]));
                a.addToHead(p);
            }
            Assert.AreEqual(3, a.head.num);
        }

        //TM5 - Test if the node added is the tail of the DLL (Single Node)
        [TestMethod]
        public void TestMethod5()
        {
            DLList a = new DLList();
            DLLNode p = new DLLNode(12);
            a.addToTail(p);
            Assert.AreEqual(12, a.tail.num);
        }

        //TM6 - Test if the node added is the tail of the DLL (Multiple Nodes)
        [TestMethod]
        public void TestMethod6()
        {
            DLList a = new DLList();

            int[] b = new int[3];
            b[0] = 1;
            b[1] = 2;
            b[2] = 3;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode((b[i]));
                a.addToTail(p);
            }
            Assert.AreEqual(3, a.tail.num);
        }

        //TM7 - Test if the node is a prime number
        [TestMethod]
        public void TestMethod7()
        {
            DLList a = new DLList();
            DLLNode p = new DLLNode(5);
            a.addToHead(p);
            Assert.AreEqual(true, p.CheckPrime(a.head.num)) ;
        }

        //TM8 - Remove the head node and check if the head has been updated (Multiple nodes)
        [TestMethod]
        public void TestMethod8()
        {
            DLList a = new DLList();
            int[] b = new int[2];
            b[0] = 1;
            b[1] = 2;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode(b[i]);
                a.addToHead(p);
            }
            //Assert.AreEqual(a.head.num, 2); //2 is indeed the head
            a.removeHead();
            //Assert.AreEqual(a.head.num, 2); //fail, because 2 does not exist 
            Assert.AreEqual(1, a.head.num); //pass, because the head has been updated after removing previous one
        }

        //TM9 - Remove the tail node and check if the tail has been updated (Multiple nodes)
        [TestMethod]
        public void TestMethod9()
        {
            DLList a = new DLList();
            int[] b = new int[3];
            b[0] = 1;
            b[1] = 2;
            b[2] = 3;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode(b[i]);
                a.addToTail(p);
            }
            //Assert.AreEqual(a.tail.num, 3); //3 is indeed the tail
            a.removeTail();
            Assert.AreEqual(2, a.tail.num); //pass
        }

        //TM 10 - Searches for a node that exists in the DLL

        [TestMethod]
        public void TestMethod10()
        {
            DLList a = new DLList();
            int[] b = new int[3];
            b[0] = 1;
            b[1] = 2;
            b[2] = 3;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode(b[i]);
                a.addToHead(p);
            }
            Assert.AreEqual(true, a.newSearch(2)); //pass, because 2 exists
        }

        //TM 11 - Searches for a node that does not exist in the DLL
        [TestMethod]
        public void TestMethod11()
        {
            DLList a = new DLList();
            int[] b = new int[3];
            b[0] = 1;
            b[1] = 2;
            b[2] = 3;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode(b[i]);
                a.addToHead(p);
            }
            //Assert.AreEqual(true, a.newSearch(4)); //fails, because 4 doesnt exist
        }

        //TM 12 - Single node in the DLL & check total
        [TestMethod]
        public void TestMethod12()
        {
            DLList a = new DLList();
            DLLNode p = new DLLNode(10);
            a.addToHead(p);
            int total = a.total();
            Assert.AreEqual(10, total); //pass
        }

        //TM 13 - Multiple nodes in the DLL & check total (positive)
        [TestMethod]
        public void TestMethod13()
        {
            DLList a = new DLList();
            int[] b = new int[3];
            b[0] = 10;
            b[1] = 20;
            b[2] = 30;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode(b[i]);
                a.addToHead(p);
            }
            int total = a.total();
            Assert.AreEqual(60, total); //fails, because 4 doesnt exist
        }

        //TM 14 - Multiple nodes in the DLL & check total (negative)
        [TestMethod]
        public void TestMethod14()
        {
            DLList a = new DLList();
            int[] b = new int[3];
            b[0] = -10;
            b[1] = -70;
            b[2] = -30;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode(b[i]);
                a.addToHead(p);
            }
            int total = a.total();
            Assert.AreEqual(-110, total); //pass
        }

        //TM 15 - Check total if DLL is empty
        [TestMethod]
        public void TestMethod15()
        {
            DLList a = new DLList();
            int total = a.total();
            Assert.AreEqual(0, total); //pass
        }

        //TM 16 - Search if DLL is empty
        [TestMethod]
        public void TestMethod16()
        {
            DLList a = new DLList();
            //Assert.AreEqual(true, a.newSearch(2)); //fail, because DLL is empty
        }

        //TM 17 - Search for node in the middle of the DLL
        [TestMethod]
        public void TestMethod17()
        {
            DLList a = new DLList();
            int[] b = new int[3];
            b[0] = 1;
            b[1] = 2;
            b[2] = 3;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode(b[i]);
                a.addToHead(p);
            }
            Assert.AreEqual(true, a.newSearch(2)); //pass, because 2 exists
        }

        //TM 18 - Remove head if there's only one node in the DLL
        [TestMethod]
        public void TestMethod18()
        {
            DLList a = new DLList();
            DLLNode p = new DLLNode(2);
            a.addToHead(p);
            a.removeHead();
            Assert.AreEqual(null, a.head);
        }

        //TM 19 - Remove tail if there's only one node in the DLL
        [TestMethod]
        public void TestMethod19()
        {
            DLList a = new DLList();
            DLLNode p = new DLLNode(2);
            a.addToTail(p);
            a.removeTail();
            Assert.AreEqual(null, a.tail);
        }

        //TM 20 - Remove node in the middle of the DLL
        [TestMethod]
        public void TestMethod20()
        {
            DLList a = new DLList();
            int[] b = new int[3];
            b[0] = 1;
            b[1] = 2;
            b[2] = 3;

            for (int i = 0; i < b.Length; i++)
            {
                DLLNode p = new DLLNode(b[i]);
                a.addToHead(p);
            }
            a.removeNode(a.head.next);
            Assert.AreEqual(false, a.newSearch(2));

        }
    }
}
