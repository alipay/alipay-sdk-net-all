namespace Aop.Api.Util
{
    /// <summary>
    /// 参数校验类
    /// </summary>
    public class ArgumentValidator
    {
        public static void CheckArgument(bool expression, string errorMessage)
        {
            if (!expression)
            {
                throw new AopException(errorMessage);
            }
        }

        public static void CheckNotNull(object value, string errorMessage)
        {
            if (value == null)
            {
                throw new AopException(errorMessage);
            }
        }

        public static void EnsureNull(object value, string errorMessage)
        {
            if (value != null)
            {
                throw new AopException(errorMessage);
            }
        }
    }
}
