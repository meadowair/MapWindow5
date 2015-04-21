﻿using System;
using System.Runtime.Serialization;
using System.Xml;
using MW5.Api;
using MW5.Api.Concrete;
using MW5.Api.Enums;
using MW5.Api.Helpers;
using MW5.Api.Interfaces;
using MW5.Api.Legend;
using MW5.Api.Legend.Abstract;

namespace MW5.Services.Serialization
{
    [DataContract]
    public class XmlLayer
    {
        public XmlLayer(ILegendLayer layer)
        {
            Layer = LayerToXmlElement(layer);
            Identity = layer.Identity;
            Expanded = layer.Expanded;
            HideFromLegend = layer.HideFromLegend;
            ColorSchemeCaption = layer.SymbologyCaption;
            Guid = layer.Guid;
            LayerType = layer.LayerType;
        }

        public void RestoreLayer(ILegendLayer layer)
        {
            layer.Deserialize(Layer.OuterXml);
            layer.Expanded = Expanded;
            layer.HideFromLegend = HideFromLegend;
            layer.SymbologyCaption = ColorSchemeCaption;
            layer.Guid = Guid;
        }

        private XmlElement LayerToXmlElement(ILegendLayer layer)
        {
            string xml = layer.Serialize();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return doc.DocumentElement;
        }

        [DataMember] public Guid Guid { get; set; }
        [DataMember] public bool Expanded { get; set; }
        [DataMember] public bool HideFromLegend { get; set; }
        [DataMember] public string ColorSchemeCaption { get; set; }
        [DataMember] public XmlElement Layer { get; set; }
        [DataMember] public LayerIdentity Identity { get; set; }
        [DataMember] public LayerType LayerType { get; set; }
    }
}
