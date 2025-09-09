using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderUserinfoNverifyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderUserinfoNverifyCreateModel : AopObject
    {
        /// <summary>
        /// 身份证号。可以传明文，也可以传身份证号的32位大写MD5值。尽量使用MD5值
        /// </summary>
        [XmlElement("identity_card")]
        public string IdentityCard { get; set; }

        /// <summary>
        /// 用户身份证姓名，如果没有可以不填
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户订单号，如果一个用户传入不同的订单号，则出库的时候会在所有订单都出库完之后才会彻底删除；如果传入相同的订单号，则一次出库就会删除。
        /// </summary>
        [XmlArray("out_biz_no")]
        [XmlArrayItem("string")]
        public List<string> OutBizNo { get; set; }

        /// <summary>
        /// 用户手机号。如果身份证选择不传，那手机号必须有。 如果有身份证信息，手机号非必须，为了后续数据输出方便，尽量传入。
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 为了给用户分到不同的类别中。 目前使用点位ID，由BD输出或者开放平台上的点位ID。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
