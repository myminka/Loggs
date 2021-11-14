using Logging.Interface;
using NLog;
using System;

namespace ConsoleApp9
{
    public class Calculator : IAlgorithm
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public int Calculate(int a, int b)
        {
            int res = 0;

            logger.Info($"Lets devide {a} to {b}");
            try
            {
                res = a /= b;
                logger.Info($"Divison was successfull result = {res}");
            }
            catch (DivideByZeroException ex)
            {
                logger.Error(ex.Message);
            }
            catch
            {
                logger.Error("Unknown message");
            }

            return res;
        }
    }
}
