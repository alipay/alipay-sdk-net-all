using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundScenepayOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundScenepayOrderCreateModel : AopObject
    {
        /// <summary>
        /// 指定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务扩展信息 mall_id:发生交易的商圈(非商圈组)的商圈唯一标识号 mall_store_id:门店编号,商户侧系统内编号 mall_pid:发生交易的商圈(非商圈组)的partnerId mall_cell_type:商圈中本次交易发生的商铺的识别类型, 可取值：SMID,SHOPID,STOREID      * mall_cell_id:商圈中本次交易发生的商铺的识别表示
        /// </summary>
        [XmlElement("business_params")]
        public ScenePayBusinessParamDTO BusinessParams { get; set; }

        /// <summary>
        /// 签约方账号。 当签约方类型是ALIPAY_USER_ID时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字； 当签约方类型是ALIPAY_LOGON_ID时，本参数为用户的支付宝登录号；当签约方类型是ALIPAY_OPEN_ID：本参数为用户的openId
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 签约方类型 ALIPAY_USER_ID：表示是支付宝账号对应的支付宝唯一用户号；ALIPAY_LOGON_ID：表示是支付宝登录号；ALIPAY_OPEN_ID：表示是支付宝开放ID
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 固定值，场景支付
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 该场景下可用的额度规则信息
        /// </summary>
        [XmlArray("quota_rule_list")]
        [XmlArrayItem("quota_rule_model_d_t_o")]
        public List<QuotaRuleModelDTO> QuotaRuleList { get; set; }

        /// <summary>
        /// 指定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
