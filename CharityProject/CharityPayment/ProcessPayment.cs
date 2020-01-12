using CharityData.Models;
using CharityProject;
using System;
using System.Linq;

namespace CharityPayment
{
    public class ProcessPayment
    {
        public bool DoPayment(Payment payment, CharityContext context)
        {
            // get object of user that is making the payment
            var userThatPays = context.user.Where(x => x.Id == payment.userSenderId).Single();
            // get object of organization that receives the payment
            var orgThatReceives = context.organization.Where(x => x.Id == payment.organizationReceiverId).Single();
            // get their credit card objects
            try
            {
                var creditCardThatPays = context.card.Where(x => x.Id == userThatPays.creditCardId).Single();
                var creditCardThatReceives = context.card.Where(x => x.Id == orgThatReceives.creditCardNumber).Single();
                if (creditCardThatPays.amount >= payment.amount && payment.amount > 0) // payment is possible
                {
                    creditCardThatPays.amount -= payment.amount;
                    creditCardThatReceives.amount += payment.amount;
                    context.Add(payment);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                 return false;
            }
            

        }
    }
}
