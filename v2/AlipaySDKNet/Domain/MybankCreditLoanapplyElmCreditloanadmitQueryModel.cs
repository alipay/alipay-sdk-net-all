using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyElmCreditloanadmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyElmCreditloanadmitQueryModel : AopObject
    {
        /// <summary>
        /// 为满足网商银行数据跨域输出的合规要求，β计划中预付融资、赊呗、采购贷、池融资、网商贷等产品相关场景进行合规确权改造，确权方案中需在业务接口入参中加入auth_scene_code（授权场景码）和auth_token（授权令牌，用于鉴权）两个字段供调用方传入字段值
        /// </summary>
        [XmlElement("mybk_auth_scene_code")]
        public string MybkAuthSceneCode { get; set; }

        /// <summary>
        /// 为满足网商银行数据跨域输出的合规要求，β计划中预付融资、赊呗、采购贷、池融资、网商贷等产品相关场景进行合规确权改造，确权方案中需在业务接口入参中加入auth_scene_code（授权场景码）和auth_token（授权令牌，用于鉴权）两个字段供调用方传入字段值
        /// </summary>
        [XmlElement("mybk_auth_token")]
        public string MybkAuthToken { get; set; }

        /// <summary>
        /// 站点的会员ID对应的open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 站点会员
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点的会员ID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
