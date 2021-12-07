using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorkFlowManagement.WorkOrder;
using WorkFlowManagement.WorkOrder.Recurrent.RecurrentWOConcreteStates;

namespace WorkFlowManagementTestProject
{
    [TestClass]
    public class RecurrentWoTests
    {
        [TestClass]
        public class ProposalUnitTests
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
                context.State.PaytoAffiliate();

                // Assert
                Assert.AreEqual(WorkOrderStatus.CompletedandInvoiced, context.State.Status);
            }


            [TestMethod]
            public void TestMethodUndo_Should_Work()
            {
                // Arrange
                var context = new RecurrentWOContext(new RecurrentWorkOrderConcretePendingSchedule());

                // Act
                context.State.Schedule();
                context.State.CheckIn();
                context.State.CheckOut();
                context.State.Undo();
                Assert.AreEqual(WorkOrderStatus.OnSite, context.State.Status);

                context.State.Undo();
                Assert.AreEqual(WorkOrderStatus.Scheduled, context.State.Status);

                context.State.Undo();
                Assert.AreEqual(WorkOrderStatus.PendingSchedule, context.State.Status);
            }

            [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]
            public void TestMethodException_Should_Throw()
            {
                // Arrange
                var context = new RecurrentWOContext(new RecurrentWorkOrderConcretePendingSchedule());

                // Act
                context.State.PaytoAffiliate();
               
            }

        }
    }
}
