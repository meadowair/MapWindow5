﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Enums;
using MW5.Api.Interfaces;

namespace MW5.Tools.Model.Parameters
{
    public static class ParameterFactory
    {
        /// <summary>
        /// Creates tool parameter for a property of a given type.
        /// </summary>
        public static BaseParameter CreateParameter(Type type)
        {
            if (type == typeof(double))
            {
                return new DoubleParameter();
            }

            if (type == typeof(int))
            {
                return new IntegerParameter();
            }

            if (type == typeof(string))
            {
                return new StringParameter();
            }

            if (type == typeof(bool))
            {
                return new BooleanParameter();
            }

            if (type == typeof(VectorLayerInfo))
            {
                return new VectorLayerParameter();
            }

            if (type == typeof(IRasterSource))
            {
                return new RasterLayerParameter();
            }

            if (type == typeof(ILayerSource))
            {
                return new LayerParameter();
            }

            if (type == typeof(Distance))
            {
                return new DistanceParameter();
            }

            if (type == typeof(OutputLayerInfo))
            {
                return new OutputLayerParameter();
            }

            // options
            throw new ApplicationException("Unexpected parameter type for the tool: " + type.Name);
        }
    }
}