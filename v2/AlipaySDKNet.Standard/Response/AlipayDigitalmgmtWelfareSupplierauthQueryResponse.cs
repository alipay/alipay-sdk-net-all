using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtWelfareSupplierauthQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtWelfareSupplierauthQueryResponse : AopResponse
    {
        /// <summary>
        /// 该参数作为家属出生日期，通过家空间小程序绑定家属中获取到，主要用于供应商为家属开通权益的必填字段之一。
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 该参数用来标识进入供应商系统的用户标志，是登录供应商应用后解析来的，蚂蚁侧将此参数作为用户标志
        /// </summary>
        [XmlElement("emp_unique_id")]
        public string EmpUniqueId { get; set; }

        /// <summary>
        /// 该参数作为用户权益扩展信息，根据供应商请求的场景查询不同用户权益归属信息
        /// </summary>
        [XmlElement("ext_info")]
        public WelfareAuthExtResp ExtInfo { get; set; }

        /// <summary>
        /// 该参数用来标识进入供应商系统的家属标志，是登录供应商应用后解析来的，蚂蚁会将此参数作为家属标志之一
        /// </summary>
        [XmlElement("family_sid")]
        public string FamilySid { get; set; }

        /// <summary>
        /// 该参数作为家属性别，通过家空间小程序绑定家属中获取到，主要用于供应商为家属开通权益的必填字段之一。
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 该字段用来判断用户是否有权益查看蚂蚁套餐内容，是根据用户查询授权信息，若有授权，则具有权益，返回true，反之返回false。供应商会依据此参数，判断页面中是否展示蚂蚁套餐内容。
        /// </summary>
        [XmlElement("has_auth")]
        public bool HasAuth { get; set; }

        /// <summary>
        /// 该参数作为家属手机号，通过家空间小程序绑定家属中获取到，主要用于供应商为家属开通权益的身份信息验证。
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 该参数作为家属姓名，通过家空间小程序绑定家属中获取到，主要用于供应商为家属开通权益的必填字段之一。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
