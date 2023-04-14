using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessDistrictInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessDistrictInfo : AopObject
    {
        /// <summary>
        /// 是否可被绑定;值是false,unbindable_error_code和unbindable_error_msg会有对应不可绑定的错误code和错误信息
        /// </summary>
        [XmlElement("bindable")]
        public bool Bindable { get; set; }

        /// <summary>
        /// 商圈ID
        /// </summary>
        [XmlElement("business_district_id")]
        public string BusinessDistrictId { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [XmlElement("business_district_name")]
        public string BusinessDistrictName { get; set; }

        /// <summary>
        /// 不可绑定错误码
        /// </summary>
        [XmlElement("unbindable_error_code")]
        public string UnbindableErrorCode { get; set; }

        /// <summary>
        /// 不可绑定错误码描述
        /// </summary>
        [XmlElement("unbindable_error_msg")]
        public string UnbindableErrorMsg { get; set; }
    }
}
