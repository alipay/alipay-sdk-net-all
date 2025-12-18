using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleInfoForm Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleInfoForm : AopObject
    {
        /// <summary>
        /// 回收账号设置，一旦设定，后续逆向退款的资金流向该账号
        /// </summary>
        [XmlElement("recycle_memo")]
        public string RecycleMemo { get; set; }

        /// <summary>
        /// 回收账号UID
        /// </summary>
        [XmlElement("recycle_user_id")]
        public string RecycleUserId { get; set; }
    }
}
