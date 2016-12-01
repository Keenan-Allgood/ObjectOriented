﻿using System;
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

    //Can I add a server to the rest object?
    [Test]
    public void  AddServer()
    {
        Server myServer=new Server("Bryan");
        addRest.addServer(myServer);
        Assert.AreEqual(1, addRest.serverList.Count);
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
}