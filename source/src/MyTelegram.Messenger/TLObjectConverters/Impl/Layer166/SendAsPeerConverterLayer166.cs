﻿namespace MyTelegram.Messenger.TLObjectConverters.Impl.Layer166;
using TSendAsPeers = MyTelegram.Schema.Channels.TSendAsPeers;
//using IPeer=MyTelegram.Schema.Channels.IPeer;

public class SendAsPeerConverterLayer166 : ISendAsPeerConverterLayer166
{
    public virtual int Layer => Layers.Layer166;

    public int RequestLayer { get; set; }

    public virtual ISendAsPeers ToSendAsPeers(long userId,
        long channelId,
        long channelCreatorId,
        IChat? channel,
        IUser? user)
    {
        if (channelCreatorId == userId)
        {
            return new TSendAsPeers
            {
                Chats = channel == null ? new TVector<IChat>() : new TVector<IChat>(channel),
                Users = new TVector<IUser>(),
                Peers = new TVector<ISendAsPeer>(new TSendAsPeer
                {
                    Peer = new TPeerChannel { ChannelId = channelId }
                })
            };
        }

        return new TSendAsPeers
        {
            Chats = new TVector<IChat>(),
            Users = user == null ? new TVector<IUser>() : new TVector<IUser>(user),
            Peers = new TVector<ISendAsPeer>(new TSendAsPeer
            {
                Peer = new TPeerUser { UserId = userId }
            })
        };
    }
}
