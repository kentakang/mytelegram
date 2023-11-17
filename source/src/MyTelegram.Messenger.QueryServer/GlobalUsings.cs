﻿global using EventFlow;
global using EventFlow.Aggregates;
global using EventFlow.Core;
global using EventFlow.EventStores;
global using EventFlow.Extensions;
global using EventFlow.Queries;
global using EventFlow.Subscribers;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using MyTelegram.Core;
global using MyTelegram.Domain;
global using MyTelegram.Domain.Aggregates.AppCode;
global using MyTelegram.Domain.Aggregates.Channel;
global using MyTelegram.Domain.Aggregates.Chat;
global using MyTelegram.Domain.Aggregates.Dialog;
global using MyTelegram.Domain.Aggregates.Pts;
global using MyTelegram.Domain.Aggregates.QrCode;
global using MyTelegram.Domain.Aggregates.RpcResult;
global using MyTelegram.Domain.Aggregates.User;
global using MyTelegram.Domain.CommandHandlers.Pts;
global using MyTelegram.Domain.Commands.Pts;
global using MyTelegram.Domain.Commands.PushUpdates;
global using MyTelegram.Domain.Commands.RpcResult;
global using MyTelegram.Domain.Events.AppCode;
global using MyTelegram.Domain.Events.Channel;
global using MyTelegram.Domain.Events.Chat;
global using MyTelegram.Domain.Events.Dialog;
global using MyTelegram.Domain.Events.Messaging;
global using MyTelegram.Domain.Events.Pts;
global using MyTelegram.Domain.Events.QrCode;
global using MyTelegram.Domain.Events.User;
global using MyTelegram.Domain.Extensions;
global using MyTelegram.Domain.Sagas;
global using MyTelegram.Domain.Sagas.Events;
global using MyTelegram.Domain.Sagas.Identities;
global using MyTelegram.Domain.ValueObjects;
global using MyTelegram.EventBus;
global using MyTelegram.EventBus.RabbitMQ;
global using MyTelegram.EventBus.Rebus;
global using MyTelegram.EventFlow.MongoDB;
global using MyTelegram.Messenger.Extensions;
global using MyTelegram.Queries;
global using MyTelegram.ReadModel;
global using MyTelegram.Schema;
global using MyTelegram.Schema.Auth;
global using MyTelegram.Schema.Messages;
global using MyTelegram.Services.Services;
global using Rebus.Config;
global using System.Buffers;
global using System.Diagnostics;
global using System.Reflection;
global using System.Threading.Tasks;
global using PtsForAuthKeyIdReadModel = MyTelegram.ReadModel.MongoDB.PtsForAuthKeyIdReadModel;
global using PtsReadModel = MyTelegram.ReadModel.MongoDB.PtsReadModel;
global using RpcResultReadModel = MyTelegram.ReadModel.MongoDB.RpcResultReadModel;
global using UpdatesReadModel = MyTelegram.ReadModel.MongoDB.UpdatesReadModel;