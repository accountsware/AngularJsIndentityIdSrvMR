﻿/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace Angular.Core.CommandEventHandlers
{
    class GenericMethodActionBuilder<TargetBase, ParamBase>
    {
        ConcurrentDictionary<Type, Action<TargetBase, ParamBase>> actionCache = new ConcurrentDictionary<Type, Action<TargetBase, ParamBase>>();

        Type targetType;
        string method;
        public GenericMethodActionBuilder(Type targetType, string method)
        {
            this.targetType = targetType;
            this.method = method;
        }

        public Action<TargetBase, ParamBase> GetAction(ParamBase paramInstance)
        {
            var paramType = paramInstance.GetType();

            if (!actionCache.ContainsKey(paramType))
            {
                actionCache[paramType] = BuildActionForMethod(paramType);
            }

            return actionCache[paramType];
        }

        private Action<TargetBase, ParamBase> BuildActionForMethod(Type paramType)
        {
            var handlerType = targetType.MakeGenericType(paramType);

            var ehParam = Expression.Parameter(typeof(TargetBase));
            var evtParam = Expression.Parameter(typeof(ParamBase));
            var invocationExpression =
                Expression.Lambda(
                    Expression.Block(
                        Expression.Call(
                            Expression.Convert(ehParam, handlerType),
                            handlerType.GetMethod(method),
                            Expression.Convert(evtParam, paramType))),
                    ehParam, evtParam);

            return (Action<TargetBase, ParamBase>)invocationExpression.Compile();
        }
    }
}
