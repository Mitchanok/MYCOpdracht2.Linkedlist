using FluentAssertions;
using MYCO2pdracht2;
using System.Xml.Linq;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_i_Add_Element_ENumeration_Will_Count_it_In_The_correct_Way()
        {
            //Assign
            var mylist = new MyLinkedList<int>();

            //Act
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);

            List<int> numbers = new List<int>();
            foreach (var item in mylist)
            {
                numbers.Add(item);
            }

            //Assert
            Assert.AreEqual(3, numbers.Count);
            Assert.AreEqual(1, numbers[0]);
            Assert.AreEqual(2, numbers[1]);
            Assert.AreEqual(3, numbers[2]);

        }
        [Test]
        public void When_I_Empty_The_List_THE_Count_Should_Be_Empty()
        {
            var mylist = new MyLinkedList<int>();

            List<int> elements = new List<int>();
            foreach (var item in mylist)
            {
                elements.Add(item);
            }

            mylist.Should().BeEmpty();
        }

        [Test]
        public void Test_If_Emuration_Is_Correct_AfterAdd()
        {
            var mylist = new MyLinkedList<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);

            mylist.Add(4);

            List<int> numbers = new List<int>();
            foreach (var item in mylist)
            {
                numbers.Add(item);
            }



            Assert.AreEqual(4, numbers.Count);
            Assert.AreEqual(1, numbers[0]);
            Assert.AreEqual(2, numbers[1]);
            Assert.AreEqual(3, numbers[2]);
            Assert.AreEqual(4, numbers[3]);
        }

        [Test]
        public void Test_If_Emuration_Is_Correct_After_Remove()
        {
            var mylist = new MyLinkedList<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);

            mylist.Remove(2);

            List<int> numbers = new List<int>();
            foreach (var item in mylist)
            {
                numbers.Add(item);
            }


            Assert.AreEqual(2, numbers.Count);
            Assert.AreEqual(1, numbers[0]);
            Assert.AreEqual(3, numbers[1]);

        }

        [Test]
        public void Test_If_Emuration_works_with_Insert()
        {
            var mylist = new MyLinkedList<int>();
            mylist.Add(56);
            mylist.Add(66);
            mylist.Add(74);
            mylist.Insert(2, 34);

            List<int> numbers = new List<int>();
            foreach (var item in mylist)
            {
                numbers.Add(item);
            }


            var index = mylist.IndexOf(34);
            mylist.Contains(34).Should().BeTrue();
            index.Should().Be(2);

            Assert.AreEqual(4, numbers.Count);
            Assert.AreEqual(56, numbers[0]);
            Assert.AreEqual(66, numbers[1]);
            Assert.AreEqual(34, numbers[2]);
            Assert.AreEqual(74, numbers[3]);

        }

        [Test]
        public void Test_Emuration_WHere_works()
        {
            var mylist = new MyLinkedList<int>();

            mylist.Add(1);
            mylist.Add(2);  
            mylist.Add(3);

            List<int> numbers = new List<int>();
            foreach (var item in mylist)
            {
                numbers.Add(item);
            }

            numbers.Where(n => n > 2);


        }




    }
}