using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterBurrypointNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterBurrypointNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 埋点下单失败消息
        /// </summary>
        [XmlElement("burry_point_error_msg")]
        public string BurryPointErrorMsg { get; set; }

        /// <summary>
        /// 埋点动作
        /// </summary>
        [XmlElement("burry_point_type")]
        public string BurryPointType { get; set; }

        /// <summary>
        /// 埋点属性
        /// </summary>
        [XmlElement("burrypoint_prop")]
        public string BurrypointProp { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 服务商医生姓名
        /// </summary>
        [XmlElement("isv_doc_name")]
        public string IsvDocName { get; set; }

        /// <summary>
        /// 服务商医生编码
        /// </summary>
        [XmlElement("isv_doc_no")]
        public string IsvDocNo { get; set; }

        /// <summary>
        /// 服务商科室名称
        /// </summary>
        [XmlElement("isv_hos_dept_name")]
        public string IsvHosDeptName { get; set; }

        /// <summary>
        /// 服务商科室ID
        /// </summary>
        [XmlElement("isv_hos_dept_no")]
        public string IsvHosDeptNo { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("isv_hos_name")]
        public string IsvHosName { get; set; }

        /// <summary>
        /// 医院唯一编码
        /// </summary>
        [XmlElement("isv_hos_no")]
        public string IsvHosNo { get; set; }

        /// <summary>
        /// 号源ID
        /// </summary>
        [XmlElement("number_id")]
        public string NumberId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 挂号订单属性
        /// </summary>
        [XmlElement("order_prop")]
        public string OrderProp { get; set; }

        /// <summary>
        /// 平台编码，由支付宝统一提供
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 号源排班日期
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 排班id
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }

        /// <summary>
        /// 支付宝url跳转三方请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 子场景编码
        /// </summary>
        [XmlElement("sub_scene_code")]
        public string SubSceneCode { get; set; }
    }
}
