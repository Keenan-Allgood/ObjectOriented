using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestaurantSeatingProject;

    [TestFixture]
    public class AddRestTest
    {
    Restaurant addRest;
    WaitListGroup theGroupWaiting;
    WaitList theGroups;
    Table hotshotTable;

        [SetUp]
        public void Init()
        {
        addRest = new Restaurant();
        addRest.Address = "305 My Drive Lincoln, NE";
        addRest.Host = "Bryan Goff";
        addRest.Manager = "Bryan Goff";
        addRest.Name = "Test";
        addRest.serverList = new List<Server>();
        addRest.TableList = new List<Table>();

        theGroupWaiting = new WaitListGroup("Bryan",2);
        theGroups = new WaitList();

        hotshotTable = new Table("John Madden's Table", 12);

        
        }

    //add restaurant
    [Test]
    public void AddRestObject()
    {
        Restaurant.oRestaurantList.Add(addRest);
        Assert.AreEqual(1, Restaurant.oRestaurantList.Count);
    }

    //Stays in the list?
    [Test]
    public void DeleteRestObject()
    {
        Restaurant.DeleteRestaurant(0);
        Assert.AreEqual(0, Restaurant.oRestaurantList.Count);
    }

    //Can I add a server to the rest object?
    [Test]
    public void  AddServer()
    {
        Server myServer=new Server("Bryan");
        addRest.addServer(myServer);
        Assert.AreEqual(1, addRest.serverList.Count);
    }

    //Positive test, removes server from restaurant but not list of servers.
    [Test]
    public void RemoveServer()
    {
        Server myServer = new Server("Bryan");
        addRest.addServer(myServer);
        addRest.removeServer(myServer);
        Assert.NotNull(myServer);
    }


    //Can we add a new Rest Name?
    [Test]
    public void ChangeRestName()
    {
        addRest.Name = "Test2";
        Assert.AreNotEqual(addRest.Name, "Test");
    }

    //Is only one waitgroup added to the waitgroup list?
    [Test]
    public void AddWaitgroup()
    {
        theGroups.WaitGroupList.Add(theGroupWaiting);
        Assert.AreEqual(1, theGroups.WaitGroupList.Count);
    }

    //Is only one table added?
    [Test]
    public void AddTable()
    {
        addRest.TableList.Add(hotshotTable);
        Assert.AreEqual(1, addRest.TableList.Count);
    }

    [Test]
    public void ClearTable()
    {
        addRest.TableList.Add(hotshotTable);
        addRest.TableList.RemoveAt(0);
        Assert.AreEqual(0, addRest.TableList.Count);
    }
    
    //Negative Test
    [Test]
    public void TestTableIndex()
    {
        TableDA myTableList = new TableDA();
        Table myTable = new Table("3", 4);
        myTableList.tables.Add(myTable);
        Assert.AreNotEqual(myTableList.tables.Count, 0);
    }

    //Negative Test
    [Test]
    public void AddWaitListGroup()
    {
        WaitListGroup myWaitlistGroup = new WaitListGroup("Bryan",3);
        WaitList myWaitlist = new WaitList();
        myWaitlist.AddGroup(myWaitlistGroup.Name,myWaitlistGroup.Size);
        Assert.AreNotEqual(myWaitlistGroup.Name, "Brianna");
    }

    public void RemoveWaitListGroup()
    {
        WaitListGroup myWaitlistGroup = new WaitListGroup("Bryan", 3);
        WaitList myWaitlist = new WaitList();
        myWaitlist.AddGroup(myWaitlistGroup.Name, myWaitlistGroup.Size);
        myWaitlist.RemoveGroup(myWaitlistGroup);
        Assert.AreNotEqual(myWaitlist.WaitGroupList.Count,1);
    }

}
