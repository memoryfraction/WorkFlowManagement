using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkFlowManagement.WorkOrder;
using WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates;

namespace WorkFlowManagementTestProject
{
    [TestClass]
    public class RecurrentWoTests
    {
        [TestMethod]
        public void TestMethodWholeWorkflowShouldWork()
        {
            // Arrange
            var context = new RecurrentWOContext(new RecurrentWorkOrderConcretePendingSchedule());

            // Act
            context.State.Schedule();
            context.State.CheckIn();
            context.State.CheckOut();
            context.State.BatchInvoice();
            context.State.PaytoAffiliate();

            // Assert
            Assert.AreEqual(WorkOrderStatus.PaytoAffiliate, context.State.Status);
        }

        [TestMethod]
        public void TestMethodReschedule_Should_Work()
        {
            // Arrange
            var context = new RecurrentWOContext(new RecurrentWorkOrderConcretePendingSchedule());

            // Act
            context.State.Schedule();
            context.State.ReSchedule();
            context.State.CheckIn();
            context.State.CheckOut();
            context.State.BatchInvoice();
            context.State.PaytoAffiliate();

            // Assert
            Assert.AreEqual(WorkOrderStatus.PaytoAffiliate, context.State.Status);
        }
    }   
}
