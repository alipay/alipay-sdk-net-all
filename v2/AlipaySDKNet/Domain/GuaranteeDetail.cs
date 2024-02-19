using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GuaranteeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GuaranteeDetail : AopObject
    {
        /// <summary>
        /// 是否对用户全额免除赔偿，不全额免除的话传false
        /// </summary>
        [XmlElement("all_free")]
        public bool AllFree { get; set; }

        /// <summary>
        /// 限额，单位分。在车损保障中，就是用户自付的限额（XX元内自付）；在三者保障、乘客保障中，就是保障的限额；在折旧费、停运费保障中，就是免收的限额（XX元内免收）；
        /// </summary>
        [XmlElement("limit_amount")]
        public long LimitAmount { get; set; }
    }
}
