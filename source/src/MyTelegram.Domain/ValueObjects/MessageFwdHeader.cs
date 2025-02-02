﻿namespace MyTelegram.Domain.ValueObjects;

public class MessageFwdHeader : ValueObject
{
    public MessageFwdHeader(Peer fromId,
        string? fromName,
        int channelPost,
        string postAuthor,
        int date,
        Peer? savedFromPeer,
        int savedFromMsgId)
    {
        FromId = fromId;
        FromName = fromName;
        ChannelPost = channelPost;
        PostAuthor = postAuthor;
        Date = date;
        SavedFromPeer = savedFromPeer;
        SavedFromMsgId = savedFromMsgId;
    }

    /// <summary>
    ///     ID of the channel message that was forwarded
    /// </summary>
    public int ChannelPost { get; init; }

    /// <summary>
    ///     When was the message originally sent
    /// </summary>
    public int Date { get; init; }

    /// <summary>
    ///     The ID of the user that originally sent the message
    /// </summary>
    public Peer FromId { get; init; }

    /// <summary>
    ///     The name of the user that originally sent the message
    /// </summary>
    public string? FromName { get; init; }

    /// <summary>
    ///     For channels and if signatures are enabled, author of the channel message
    /// </summary>
    public string PostAuthor { get; init; }

    /// <summary>
    ///     Only for messages forwarded to the current user (inputPeerSelf), ID of the message that was forwarded from the
    ///     original user/channel
    /// </summary>
    public int SavedFromMsgId { get; init; }

    /// <summary>
    ///     Only for messages forwarded to the current user (inputPeerSelf), full info about the user/channel that originally
    ///     sent the message
    /// </summary>
    public Peer? SavedFromPeer { get; init; }
}
