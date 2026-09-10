using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: enqueue with different priorities and equal priorities mixed
    // Luca 2, Rafa 3, Fede 3, Manuel 5, Magui 5
    // Expected Result: Manuel, Magui, Rafa, Fede, Luca
    // Defect(s) Found: FIFO didn't work because of >= we never had a priority with same number of turns.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Luca",2);
        priorityQueue.Enqueue("Rafa",3);
        priorityQueue.Enqueue("Fede",3);
        priorityQueue.Enqueue("Manuel",5);
        priorityQueue.Enqueue("Magui",5);

        Assert.AreEqual("Manuel",priorityQueue.Dequeue());
        Assert.AreEqual("Magui",priorityQueue.Dequeue());
        Assert.AreEqual("Rafa",priorityQueue.Dequeue());
        Assert.AreEqual("Fede",priorityQueue.Dequeue());
        Assert.AreEqual("Luca",priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: enqueue with priority when enlisted at the end
    // Luca 3, Fede 5, Magui 10
    // Expected Result: Magui at first
    // Defect(s) Found: when the loop condition was _queue.Count-1 we weren't checking the last element. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Luca",3);
        priorityQueue.Enqueue("Fede",5);
        priorityQueue.Enqueue("Magui",10);

        Assert.AreEqual("Magui",priorityQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: empty queues should be empty
    // Expected Result: Invalid Operation should be thrown a message with "The queue is empty"
    // Defect found: none, that was working since the last part;
    public void TestPriorityQueue_empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception type {e.GetType()} caught {e.Message}");
        }
    }

    // Add more test cases as needed below.
}