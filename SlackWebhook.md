<a name='assembly'></a>
# SlackWebhook

## Contents

- [FormattedTextEncoder](#T-SlackWebhook-Core-FormattedTextEncoder 'SlackWebhook.Core.FormattedTextEncoder')
- [IconType](#T-SlackWebhook-Enums-IconType 'SlackWebhook.Enums.IconType')
  - [Emoji](#F-SlackWebhook-Enums-IconType-Emoji 'SlackWebhook.Enums.IconType.Emoji')
  - [Url](#F-SlackWebhook-Enums-IconType-Url 'SlackWebhook.Enums.IconType.Url')
- [ISlackAttachmentBuilder](#T-SlackWebhook-ISlackAttachmentBuilder 'SlackWebhook.ISlackAttachmentBuilder')
  - [WithAuthor(name,linkUrl,iconUrl)](#M-SlackWebhook-ISlackAttachmentBuilder-WithAuthor-System-String,System-String,System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithAuthor(System.String,System.String,System.String)')
  - [WithColor(hexColor)](#M-SlackWebhook-ISlackAttachmentBuilder-WithColor-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithColor(System.String)')
  - [WithColor(color)](#M-SlackWebhook-ISlackAttachmentBuilder-WithColor-System-Drawing-Color- 'SlackWebhook.ISlackAttachmentBuilder.WithColor(System.Drawing.Color)')
  - [WithFallback(fallback)](#M-SlackWebhook-ISlackAttachmentBuilder-WithFallback-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithFallback(System.String)')
  - [WithField(title,value,isShort,enableFormatting)](#M-SlackWebhook-ISlackAttachmentBuilder-WithField-System-String,System-String,System-Boolean,System-Boolean- 'SlackWebhook.ISlackAttachmentBuilder.WithField(System.String,System.String,System.Boolean,System.Boolean)')
  - [WithFooter(text,iconUrl)](#M-SlackWebhook-ISlackAttachmentBuilder-WithFooter-System-String,System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithFooter(System.String,System.String)')
  - [WithImage(url)](#M-SlackWebhook-ISlackAttachmentBuilder-WithImage-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithImage(System.String)')
  - [WithLink(url)](#M-SlackWebhook-ISlackAttachmentBuilder-WithLink-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithLink(System.String)')
  - [WithPreText(text,enableFormatting)](#M-SlackWebhook-ISlackAttachmentBuilder-WithPreText-System-String,System-Boolean- 'SlackWebhook.ISlackAttachmentBuilder.WithPreText(System.String,System.Boolean)')
  - [WithText(text,enableFormatting)](#M-SlackWebhook-ISlackAttachmentBuilder-WithText-System-String,System-Boolean- 'SlackWebhook.ISlackAttachmentBuilder.WithText(System.String,System.Boolean)')
  - [WithThumbnail(url)](#M-SlackWebhook-ISlackAttachmentBuilder-WithThumbnail-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithThumbnail(System.String)')
  - [WithTimestamp(timestamp)](#M-SlackWebhook-ISlackAttachmentBuilder-WithTimestamp-System-DateTimeOffset- 'SlackWebhook.ISlackAttachmentBuilder.WithTimestamp(System.DateTimeOffset)')
  - [WithTimestamp(epochTime)](#M-SlackWebhook-ISlackAttachmentBuilder-WithTimestamp-System-Int32- 'SlackWebhook.ISlackAttachmentBuilder.WithTimestamp(System.Int32)')
  - [WithTitle(title)](#M-SlackWebhook-ISlackAttachmentBuilder-WithTitle-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithTitle(System.String)')
- [ISlackClient](#T-SlackWebhook-ISlackClient 'SlackWebhook.ISlackClient')
  - [SendAsync(configureBuilder)](#M-SlackWebhook-ISlackClient-SendAsync-System-Action{SlackWebhook-ISlackMessageBuilder}- 'SlackWebhook.ISlackClient.SendAsync(System.Action{SlackWebhook.ISlackMessageBuilder})')
  - [SendAsync(message)](#M-SlackWebhook-ISlackClient-SendAsync-SlackWebhook-Messages-SlackMessage- 'SlackWebhook.ISlackClient.SendAsync(SlackWebhook.Messages.SlackMessage)')
- [ISlackMessageBuilder](#T-SlackWebhook-ISlackMessageBuilder 'SlackWebhook.ISlackMessageBuilder')
  - [Build()](#M-SlackWebhook-ISlackMessageBuilder-Build 'SlackWebhook.ISlackMessageBuilder.Build')
  - [WithAttachment(configureAttachment)](#M-SlackWebhook-ISlackMessageBuilder-WithAttachment-System-Action{SlackWebhook-ISlackAttachmentBuilder}- 'SlackWebhook.ISlackMessageBuilder.WithAttachment(System.Action{SlackWebhook.ISlackAttachmentBuilder})')
  - [WithChannel(channel)](#M-SlackWebhook-ISlackMessageBuilder-WithChannel-System-String- 'SlackWebhook.ISlackMessageBuilder.WithChannel(System.String)')
  - [WithIcon(iconType,urlOrEmoji)](#M-SlackWebhook-ISlackMessageBuilder-WithIcon-SlackWebhook-Enums-IconType,System-String- 'SlackWebhook.ISlackMessageBuilder.WithIcon(SlackWebhook.Enums.IconType,System.String)')
  - [WithText(text,enableFormatting)](#M-SlackWebhook-ISlackMessageBuilder-WithText-System-String,System-Boolean- 'SlackWebhook.ISlackMessageBuilder.WithText(System.String,System.Boolean)')
  - [WithUsername(username)](#M-SlackWebhook-ISlackMessageBuilder-WithUsername-System-String- 'SlackWebhook.ISlackMessageBuilder.WithUsername(System.String)')
- [SlackAttachment](#T-SlackWebhook-Messages-SlackAttachment 'SlackWebhook.Messages.SlackAttachment')
  - [FormattingFields](#F-SlackWebhook-Messages-SlackAttachment-FormattingFields 'SlackWebhook.Messages.SlackAttachment.FormattingFields')
  - [FormattingPretext](#F-SlackWebhook-Messages-SlackAttachment-FormattingPretext 'SlackWebhook.Messages.SlackAttachment.FormattingPretext')
  - [FormattingText](#F-SlackWebhook-Messages-SlackAttachment-FormattingText 'SlackWebhook.Messages.SlackAttachment.FormattingText')
  - [AuthorIcon](#P-SlackWebhook-Messages-SlackAttachment-AuthorIcon 'SlackWebhook.Messages.SlackAttachment.AuthorIcon')
  - [AuthorLink](#P-SlackWebhook-Messages-SlackAttachment-AuthorLink 'SlackWebhook.Messages.SlackAttachment.AuthorLink')
  - [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')
  - [Color](#P-SlackWebhook-Messages-SlackAttachment-Color 'SlackWebhook.Messages.SlackAttachment.Color')
  - [EnableFormatting](#P-SlackWebhook-Messages-SlackAttachment-EnableFormatting 'SlackWebhook.Messages.SlackAttachment.EnableFormatting')
  - [Fallback](#P-SlackWebhook-Messages-SlackAttachment-Fallback 'SlackWebhook.Messages.SlackAttachment.Fallback')
  - [Fields](#P-SlackWebhook-Messages-SlackAttachment-Fields 'SlackWebhook.Messages.SlackAttachment.Fields')
  - [Footer](#P-SlackWebhook-Messages-SlackAttachment-Footer 'SlackWebhook.Messages.SlackAttachment.Footer')
  - [FooterIcon](#P-SlackWebhook-Messages-SlackAttachment-FooterIcon 'SlackWebhook.Messages.SlackAttachment.FooterIcon')
  - [ImageUrl](#P-SlackWebhook-Messages-SlackAttachment-ImageUrl 'SlackWebhook.Messages.SlackAttachment.ImageUrl')
  - [PreText](#P-SlackWebhook-Messages-SlackAttachment-PreText 'SlackWebhook.Messages.SlackAttachment.PreText')
  - [Text](#P-SlackWebhook-Messages-SlackAttachment-Text 'SlackWebhook.Messages.SlackAttachment.Text')
  - [ThumbnailUrl](#P-SlackWebhook-Messages-SlackAttachment-ThumbnailUrl 'SlackWebhook.Messages.SlackAttachment.ThumbnailUrl')
  - [Timestamp](#P-SlackWebhook-Messages-SlackAttachment-Timestamp 'SlackWebhook.Messages.SlackAttachment.Timestamp')
  - [Title](#P-SlackWebhook-Messages-SlackAttachment-Title 'SlackWebhook.Messages.SlackAttachment.Title')
  - [TitleLink](#P-SlackWebhook-Messages-SlackAttachment-TitleLink 'SlackWebhook.Messages.SlackAttachment.TitleLink')
  - [SetColor(color)](#M-SlackWebhook-Messages-SlackAttachment-SetColor-System-Drawing-Color- 'SlackWebhook.Messages.SlackAttachment.SetColor(System.Drawing.Color)')
  - [SetTimestamp(timestamp)](#M-SlackWebhook-Messages-SlackAttachment-SetTimestamp-System-DateTimeOffset- 'SlackWebhook.Messages.SlackAttachment.SetTimestamp(System.DateTimeOffset)')
  - [Validate(validationErrors)](#M-SlackWebhook-Messages-SlackAttachment-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackAttachment.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [SlackAttachmentBuilder](#T-SlackWebhook-SlackAttachmentBuilder 'SlackWebhook.SlackAttachmentBuilder')
  - [SetEnableFormatting(formattingType,enable)](#M-SlackWebhook-SlackAttachmentBuilder-SetEnableFormatting-System-String,System-Boolean- 'SlackWebhook.SlackAttachmentBuilder.SetEnableFormatting(System.String,System.Boolean)')
- [SlackAttachmentField](#T-SlackWebhook-Messages-SlackAttachmentField 'SlackWebhook.Messages.SlackAttachmentField')
  - [Short](#P-SlackWebhook-Messages-SlackAttachmentField-Short 'SlackWebhook.Messages.SlackAttachmentField.Short')
  - [Title](#P-SlackWebhook-Messages-SlackAttachmentField-Title 'SlackWebhook.Messages.SlackAttachmentField.Title')
  - [Value](#P-SlackWebhook-Messages-SlackAttachmentField-Value 'SlackWebhook.Messages.SlackAttachmentField.Value')
  - [Validate(validationErrors)](#M-SlackWebhook-Messages-SlackAttachmentField-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackAttachmentField.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')
  - [Attachments](#P-SlackWebhook-Messages-SlackMessage-Attachments 'SlackWebhook.Messages.SlackMessage.Attachments')
  - [Channel](#P-SlackWebhook-Messages-SlackMessage-Channel 'SlackWebhook.Messages.SlackMessage.Channel')
  - [EnableFormatting](#P-SlackWebhook-Messages-SlackMessage-EnableFormatting 'SlackWebhook.Messages.SlackMessage.EnableFormatting')
  - [IconEmoji](#P-SlackWebhook-Messages-SlackMessage-IconEmoji 'SlackWebhook.Messages.SlackMessage.IconEmoji')
  - [IconUrl](#P-SlackWebhook-Messages-SlackMessage-IconUrl 'SlackWebhook.Messages.SlackMessage.IconUrl')
  - [Text](#P-SlackWebhook-Messages-SlackMessage-Text 'SlackWebhook.Messages.SlackMessage.Text')
  - [Username](#P-SlackWebhook-Messages-SlackMessage-Username 'SlackWebhook.Messages.SlackMessage.Username')
  - [ThrowIfInvalid()](#M-SlackWebhook-Messages-SlackMessage-ThrowIfInvalid 'SlackWebhook.Messages.SlackMessage.ThrowIfInvalid')
  - [Validate()](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [ValidationError](#T-SlackWebhook-Exceptions-ValidationError 'SlackWebhook.Exceptions.ValidationError')

<a name='T-SlackWebhook-Core-FormattedTextEncoder'></a>
## FormattedTextEncoder `type`

##### Namespace

SlackWebhook.Core

##### Summary

Handles escaping characters which the Slack webhook expects to be HTML 
            encoded.



See https://api.slack.com/docs/message-formatting#how_to_escape_characters
            for more.

<a name='T-SlackWebhook-Enums-IconType'></a>
## IconType `type`

##### Namespace

SlackWebhook.Enums

<a name='F-SlackWebhook-Enums-IconType-Emoji'></a>
### Emoji `constants`

##### Summary

Icon is a slack emoji name, e.g.

```
smile
```

<a name='F-SlackWebhook-Enums-IconType-Url'></a>
### Url `constants`

##### Summary

Icon is a image URL

<a name='T-SlackWebhook-ISlackAttachmentBuilder'></a>
## ISlackAttachmentBuilder `type`

##### Namespace

SlackWebhook

##### Summary

Slack attachment builder used to configure an attachment to be added to a [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithAuthor-System-String,System-String,System-String-'></a>
### WithAuthor(name,linkUrl,iconUrl) `method`

##### Summary

With author name, and optional link url and icon url

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Author name (required) |
| linkUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Author link url (optional) |
| iconUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Author icon url (optional) |

##### Remarks

The author parameters will display a small section at the top of a
            message attachment.



A valid URL that will hyperlink the [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName') text
            mentioned above. Will only work if [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName') is
            present.



A valid URL that displays a small 16x16px image to the left of the
            [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName') text. Will only work if
            [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName') is present.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithColor-System-String-'></a>
### WithColor(hexColor) `method`

##### Summary

With hex-based color

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hexColor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Hex color or one of named colors (good, warning, danger) |

##### Remarks

Like traffic signals, color-coding messages can quickly communicate
            intent and help separate them from the flow of other messages in the
            timeline.



An optional value that can either be one of good, warning, danger,
            or any hex color code(eg. #439FE0). This value is used to color the
            border along the left side of the message attachment.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithColor-System-Drawing-Color-'></a>
### WithColor(color) `method`

##### Summary

With color from [Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.Drawing.Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') | Color instance to set color from |

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithFallback-System-String-'></a>
### WithFallback(fallback) `method`

##### Summary

With required plain-text summary of the attachment

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fallback | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

A plain-text summary of the attachment. This text will be used in 
            clients that don't show formatted text (eg. IRC, mobile 
            notifications) and should not contain any markup.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithField-System-String,System-String,System-Boolean,System-Boolean-'></a>
### WithField(title,value,isShort,enableFormatting) `method`

##### Summary

With attachment field shown as a table inside the message attachment

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Title of field



Shown as a bold heading above the value text. It cannot contain
            markup and will be escaped for you. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of field (may contain formatting if enabled)



The text value of the field. It may contain standard message markup
            and must be escaped as normal. May be multi-line. |
| isShort | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether field can be shown side-by-side with other fields (optional) |
| enableFormatting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to enable formatting for value |

##### Remarks

If `enableFormatting` is enabled, you can use Slack message formatting in 
            `value` and it will automatically be encoded according to slack encoding rules.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithFooter-System-String,System-String-'></a>
### WithFooter(text,iconUrl) `method`

##### Summary

With footer text and optional footer icon

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| iconUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Add some brief text to help contextualize and identify an
            attachment. Limited to 300 characters, and may be truncated further
            when displayed to users in environments with limited screen real
            estate.



To render a small icon beside your footer text, provide a publicly
            accessible URL string in the footer_icon field. You must also
            provide a footer for the field to be recognized.



We'll render what you provide at 16px by 16px. It's best to use an
            image that is similarly sized.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithImage-System-String-'></a>
### WithImage(url) `method`

##### Summary

With image url

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Image url |

##### Remarks

A valid URL to an image file that will be displayed inside a message
            attachment. We currently support the following formats: GIF, JPEG,
            PNG, and BMP.



Large images will be resized to a maximum width of 400px or a
            maximum height of 500px, while still maintaining the original aspect
            ratio.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithLink-System-String-'></a>
### WithLink(url) `method`

##### Summary

With link on attachment title

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Link of title (optional)

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithPreText-System-String,System-Boolean-'></a>
### WithPreText(text,enableFormatting) `method`

##### Summary

With optional pre-text

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Pre-text |
| enableFormatting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to enable formatting for text |

##### Remarks

This is optional text that appears above the message attachment
            block.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithText-System-String,System-Boolean-'></a>
### WithText(text,enableFormatting) `method`

##### Summary

With optional text

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text |
| enableFormatting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to enable formatting for text |

##### Remarks

This is the main text in a message attachment, and can contain
            standard message markup. The content will automatically collapse if
            it contains 700+ characters or 5+ linebreaks, and will display a
            "Show more..." link to expand the content. Links posted in the text
            field will not unfurl.



If `enableFormatting` is enabled, you can use Slack message formatting in 
            `text` and it will automatically be encoded according to slack encoding rules.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithThumbnail-System-String-'></a>
### WithThumbnail(url) `method`

##### Summary

With thumbnail url

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Thumbnail url |

##### Remarks

A valid URL to an image file that will be displayed as a thumbnail
            on the right side of a message attachment. We currently support the
            following formats: GIF, JPEG, PNG, and BMP.



The thumbnail's longest dimension will be scaled down to 75px while
            maintaining the aspect ratio of the image. The filesize of the image
            must also be less than 500 KB.



For best results, please use images that are already 75px by 75px.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithTimestamp-System-DateTimeOffset-'></a>
### WithTimestamp(timestamp) `method`

##### Summary

With timestamp based on `timestamp`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timestamp | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | DateTimeOffset to set timestamp from |

##### Remarks

Does your attachment relate to something happening at a specific 
            time?



By providing the ts field with an integer value in "epoch time",
            the attachment will display an additional timestamp value as part of
            the attachment's footer.



Use ts when referencing articles or happenings.Your message will 
            have its own timestamp when published.



Example: Providing 123456789 would result in a rendered timestamp 
            of Nov 29th, 1973.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithTimestamp-System-Int32-'></a>
### WithTimestamp(epochTime) `method`

##### Summary

With epoc timestamp

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| epochTime | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Epoch timestamp |

##### Remarks

Does your attachment relate to something happening at a specific 
            time?



By providing the ts field with an integer value in "epoch time",
            the attachment will display an additional timestamp value as part of
            the attachment's footer.



Use ts when referencing articles or happenings.Your message will 
            have its own timestamp when published.



Example: Providing 123456789 would result in a rendered timestamp 
            of Nov 29th, 1973.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithTitle-System-String-'></a>
### WithTitle(title) `method`

##### Summary

With required title

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Title |

##### Remarks

The title is displayed as larger, bold text near the top of a
            message attachment. By passing a valid URL in the
            [TitleLink](#P-SlackWebhook-Messages-SlackAttachment-TitleLink 'SlackWebhook.Messages.SlackAttachment.TitleLink') parameter (optional), the title text will be

<a name='T-SlackWebhook-ISlackClient'></a>
## ISlackClient `type`

##### Namespace

SlackWebhook

<a name='M-SlackWebhook-ISlackClient-SendAsync-System-Action{SlackWebhook-ISlackMessageBuilder}-'></a>
### SendAsync(configureBuilder) `method`

##### Summary

Send new [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage') by configuring the provided [ISlackMessageBuilder](#T-SlackWebhook-ISlackMessageBuilder 'SlackWebhook.ISlackMessageBuilder')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configureBuilder | [System.Action{SlackWebhook.ISlackMessageBuilder}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{SlackWebhook.ISlackMessageBuilder}') | Configure message to send using this builder |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [SlackWebhook.Exceptions.SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException') | Thrown if validation of the message fails, such as if a required field is missing.



Uses [Validate](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)') to perform validation. |

<a name='M-SlackWebhook-ISlackClient-SendAsync-SlackWebhook-Messages-SlackMessage-'></a>
### SendAsync(message) `method`

##### Summary

Send the provided [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [SlackWebhook.Messages.SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage') | Slack message to send |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [SlackWebhook.Exceptions.SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException') | Thrown if validation of the message fails, such as if a required field is missing.



Uses [Validate](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)') to perform validation. |

<a name='T-SlackWebhook-ISlackMessageBuilder'></a>
## ISlackMessageBuilder `type`

##### Namespace

SlackWebhook

##### Summary

Slack message builder that produces [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage') instances based on the builder's
            current configuration.

<a name='M-SlackWebhook-ISlackMessageBuilder-Build'></a>
### Build() `method`

##### Summary

Build [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage') based on current state of the builder

##### Returns

New message

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [SlackWebhook.Exceptions.SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException') | Thrown if validation of the message fails, such as if a required field is missing.



Uses [Validate](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)') to perform validation. |

<a name='M-SlackWebhook-ISlackMessageBuilder-WithAttachment-System-Action{SlackWebhook-ISlackAttachmentBuilder}-'></a>
### WithAttachment(configureAttachment) `method`

##### Summary

With attachment build with provided attachment builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configureAttachment | [System.Action{SlackWebhook.ISlackAttachmentBuilder}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{SlackWebhook.ISlackAttachmentBuilder}') | Attachment builder |

##### Remarks

Adds a new [SlackAttachment](#T-SlackWebhook-Messages-SlackAttachment 'SlackWebhook.Messages.SlackAttachment') to [Attachments](#P-SlackWebhook-Messages-SlackMessage-Attachments 'SlackWebhook.Messages.SlackMessage.Attachments') built using provided 
            [ISlackAttachmentBuilder](#T-SlackWebhook-ISlackAttachmentBuilder 'SlackWebhook.ISlackAttachmentBuilder')

<a name='M-SlackWebhook-ISlackMessageBuilder-WithChannel-System-String-'></a>
### WithChannel(channel) `method`

##### Summary

With channel

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The channel. |

##### Remarks

Sets the [Channel](#P-SlackWebhook-Messages-SlackMessage-Channel 'SlackWebhook.Messages.SlackMessage.Channel') property

<a name='M-SlackWebhook-ISlackMessageBuilder-WithIcon-SlackWebhook-Enums-IconType,System-String-'></a>
### WithIcon(iconType,urlOrEmoji) `method`

##### Summary

With icon (url or emoji)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iconType | [SlackWebhook.Enums.IconType](#T-SlackWebhook-Enums-IconType 'SlackWebhook.Enums.IconType') | Type of icon |
| urlOrEmoji | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL or emoji name (depending on `iconType`) |

##### Remarks

Sets the [IconUrl](#P-SlackWebhook-Messages-SlackMessage-IconUrl 'SlackWebhook.Messages.SlackMessage.IconUrl') or [IconEmoji](#P-SlackWebhook-Messages-SlackMessage-IconEmoji 'SlackWebhook.Messages.SlackMessage.IconEmoji') based on
            `iconType` with the provided value `urlOrEmoji`

<a name='M-SlackWebhook-ISlackMessageBuilder-WithText-System-String,System-Boolean-'></a>
### WithText(text,enableFormatting) `method`

##### Summary

With required message text

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message text |
| enableFormatting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to enable formatting for text |

##### Remarks

Sets the [Text](#P-SlackWebhook-Messages-SlackMessage-Text 'SlackWebhook.Messages.SlackMessage.Text') and [EnableFormatting](#P-SlackWebhook-Messages-SlackMessage-EnableFormatting 'SlackWebhook.Messages.SlackMessage.EnableFormatting') properties.



If `enableFormatting` is enabled, you can use Slack message formatting in
            `text` and it will automatically be encoded according to slack encoding rules.

<a name='M-SlackWebhook-ISlackMessageBuilder-WithUsername-System-String-'></a>
### WithUsername(username) `method`

##### Summary

With username

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Username |

##### Remarks

Sets the [Username](#P-SlackWebhook-Messages-SlackMessage-Username 'SlackWebhook.Messages.SlackMessage.Username') property

<a name='T-SlackWebhook-Messages-SlackAttachment'></a>
## SlackAttachment `type`

##### Namespace

SlackWebhook.Messages

##### Summary

Optional attachment to a [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage').



See https://api.slack.com/docs/message-attachments for more details

<a name='F-SlackWebhook-Messages-SlackAttachment-FormattingFields'></a>
### FormattingFields `constants`

##### Summary

Used to enable formatting of the [Fields](#P-SlackWebhook-Messages-SlackAttachment-Fields 'SlackWebhook.Messages.SlackAttachment.Fields') value fields

<a name='F-SlackWebhook-Messages-SlackAttachment-FormattingPretext'></a>
### FormattingPretext `constants`

##### Summary

Used to enable formatting of the [PreText](#P-SlackWebhook-Messages-SlackAttachment-PreText 'SlackWebhook.Messages.SlackAttachment.PreText') field

<a name='F-SlackWebhook-Messages-SlackAttachment-FormattingText'></a>
### FormattingText `constants`

##### Summary

Used to enable formatting of the [Text](#P-SlackWebhook-Messages-SlackAttachment-Text 'SlackWebhook.Messages.SlackAttachment.Text') field

<a name='P-SlackWebhook-Messages-SlackAttachment-AuthorIcon'></a>
### AuthorIcon `property`

##### Summary

Author icon URL (optional)

##### Remarks

A valid URL that displays a small 16x16px image to the left of the
            [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName') text. Will only work if
            [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName') is present.

<a name='P-SlackWebhook-Messages-SlackAttachment-AuthorLink'></a>
### AuthorLink `property`

##### Summary

Author link (optional)

##### Remarks

A valid URL that will hyperlink the [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName') text
            mentioned above. Will only work if [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName') is
            present.

<a name='P-SlackWebhook-Messages-SlackAttachment-AuthorName'></a>
### AuthorName `property`

##### Summary

Author name (optional)

##### Remarks

The author parameters will display a small section at the top of a
            message attachment

<a name='P-SlackWebhook-Messages-SlackAttachment-Color'></a>
### Color `property`

##### Summary

Gets or sets the color.

##### Remarks

Like traffic signals, color-coding messages can quickly communicate
            intent and help separate them from the flow of other messages in the
            timeline.



An optional value that can either be one of good, warning, danger,
            or any hex color code(eg. #439FE0). This value is used to color the
            border along the left side of the message attachment.

<a name='P-SlackWebhook-Messages-SlackAttachment-EnableFormatting'></a>
### EnableFormatting `property`

##### Summary

Enable formatting for various fields of the attachment, use 
            [FormattingText](#F-SlackWebhook-Messages-SlackAttachment-FormattingText 'SlackWebhook.Messages.SlackAttachment.FormattingText'), [FormattingPretext](#F-SlackWebhook-Messages-SlackAttachment-FormattingPretext 'SlackWebhook.Messages.SlackAttachment.FormattingPretext') and
            [FormattingFields](#F-SlackWebhook-Messages-SlackAttachment-FormattingFields 'SlackWebhook.Messages.SlackAttachment.FormattingFields') to contorl which fields have 
            formatting enabled.

<a name='P-SlackWebhook-Messages-SlackAttachment-Fallback'></a>
### Fallback `property`

##### Summary

Required plain-text summary of the attachment

##### Remarks

A plain-text summary of the attachment. This text will be used in 
            clients that don't show formatted text (eg. IRC, mobile 
            notifications) and should not contain any markup.

<a name='P-SlackWebhook-Messages-SlackAttachment-Fields'></a>
### Fields `property`

##### Summary

Fields shown as a table inside the message attachment (optional)

<a name='P-SlackWebhook-Messages-SlackAttachment-Footer'></a>
### Footer `property`

##### Summary

Footer text shown at the bottom of attachment (optional)

##### Remarks

Add some brief text to help contextualize and identify an
            attachment. Limited to 300 characters, and may be truncated further
            when displayed to users in environments with limited screen real
            estate.

<a name='P-SlackWebhook-Messages-SlackAttachment-FooterIcon'></a>
### FooterIcon `property`

##### Summary

Icon shown left of footer text (optional)

##### Remarks

To render a small icon beside your footer text, provide a publicly
            accessible URL string in the footer_icon field. You must also
            provide a footer for the field to be recognized.



We'll render what you provide at 16px by 16px. It's best to use an
            image that is similarly sized.

<a name='P-SlackWebhook-Messages-SlackAttachment-ImageUrl'></a>
### ImageUrl `property`

##### Summary

Image url (optional)

##### Remarks

A valid URL to an image file that will be displayed inside a message
            attachment. We currently support the following formats: GIF, JPEG,
            PNG, and BMP.



Large images will be resized to a maximum width of 400px or a
            maximum height of 500px, while still maintaining the original aspect
            ratio.

<a name='P-SlackWebhook-Messages-SlackAttachment-PreText'></a>
### PreText `property`

##### Summary

Optional text that appears above the attachment block

##### Remarks

This is optional text that appears above the message attachment
            block.

<a name='P-SlackWebhook-Messages-SlackAttachment-Text'></a>
### Text `property`

##### Summary

Optional text that appears within the attachment

##### Remarks

This is the main text in a message attachment, and can contain
            standard message markup. The content will automatically collapse if
            it contains 700+ characters or 5+ linebreaks, and will display a
            "Show more..." link to expand the content. Links posted in the text
            field will not unfurl.

<a name='P-SlackWebhook-Messages-SlackAttachment-ThumbnailUrl'></a>
### ThumbnailUrl `property`

##### Summary

Thumbnail url (optional)

##### Remarks

A valid URL to an image file that will be displayed as a thumbnail
            on the right side of a message attachment. We currently support the
            following formats: GIF, JPEG, PNG, and BMP.



The thumbnail's longest dimension will be scaled down to 75px while
            maintaining the aspect ratio of the image. The filesize of the image
            must also be less than 500 KB.



For best results, please use images that are already 75px by 75px.

<a name='P-SlackWebhook-Messages-SlackAttachment-Timestamp'></a>
### Timestamp `property`

##### Summary

Timestamp (epoch time) shown below attachment (optional)

##### Remarks

Does your attachment relate to something happening at a specific 
            time?



By providing the ts field with an integer value in "epoch time",
            the attachment will display an additional timestamp value as part of
            the attachment's footer.



Use ts when referencing articles or happenings.Your message will 
            have its own timestamp when published.



Example: Providing 123456789 would result in a rendered timestamp 
            of Nov 29th, 1973.

<a name='P-SlackWebhook-Messages-SlackAttachment-Title'></a>
### Title `property`

##### Summary

Title of attachment (required)

##### Remarks

The title is displayed as larger, bold text near the top of a
            message attachment. By passing a valid URL in the
            [TitleLink](#P-SlackWebhook-Messages-SlackAttachment-TitleLink 'SlackWebhook.Messages.SlackAttachment.TitleLink') parameter (optional), the title text will be
            hyperlinked.

<a name='P-SlackWebhook-Messages-SlackAttachment-TitleLink'></a>
### TitleLink `property`

##### Summary

Link of title (optional)

<a name='M-SlackWebhook-Messages-SlackAttachment-SetColor-System-Drawing-Color-'></a>
### SetColor(color) `method`

##### Summary

Set color hex code from [Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.Drawing.Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') | Color to set color hex from |

<a name='M-SlackWebhook-Messages-SlackAttachment-SetTimestamp-System-DateTimeOffset-'></a>
### SetTimestamp(timestamp) `method`

##### Summary

Set [Timestamp](#P-SlackWebhook-Messages-SlackAttachment-Timestamp 'SlackWebhook.Messages.SlackAttachment.Timestamp') epoch value based on provided date time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timestamp | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | Timestamp to set epohc time from |

<a name='M-SlackWebhook-Messages-SlackAttachment-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate(validationErrors) `method`

##### Summary

Validates the current state of the attachment (including any nested
            elements, such as [Fields](#P-SlackWebhook-Messages-SlackAttachment-Fields 'SlackWebhook.Messages.SlackAttachment.Fields'))

##### Returns

True if the attachment is valid, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationErrors | [System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@') |  |

<a name='T-SlackWebhook-SlackAttachmentBuilder'></a>
## SlackAttachmentBuilder `type`

##### Namespace

SlackWebhook

<a name='M-SlackWebhook-SlackAttachmentBuilder-SetEnableFormatting-System-String,System-Boolean-'></a>
### SetEnableFormatting(formattingType,enable) `method`

##### Summary

Enables or disables formatting by adding/removing `formattingType` from
            [EnableFormatting](#P-SlackWebhook-Messages-SlackAttachment-EnableFormatting 'SlackWebhook.Messages.SlackAttachment.EnableFormatting')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formattingType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Formatting type |
| enable | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether to enable (add) or disable (remove) |

<a name='T-SlackWebhook-Messages-SlackAttachmentField'></a>
## SlackAttachmentField `type`

##### Namespace

SlackWebhook.Messages

##### Summary

Optional attachment field added to [Fields](#P-SlackWebhook-Messages-SlackAttachment-Fields 'SlackWebhook.Messages.SlackAttachment.Fields')

<a name='P-SlackWebhook-Messages-SlackAttachmentField-Short'></a>
### Short `property`

##### Summary

Whether field can be shown side-by-side with other fields (optional)

<a name='P-SlackWebhook-Messages-SlackAttachmentField-Title'></a>
### Title `property`

##### Summary

Title of field

##### Remarks

Shown as a bold heading above the value text. It cannot contain
            markup and will be escaped for you.

<a name='P-SlackWebhook-Messages-SlackAttachmentField-Value'></a>
### Value `property`

##### Summary

Value of field (may contain formatting if enabled)

##### Remarks

The text value of the field. It may contain standard message markup
            and must be escaped as normal. May be multi-line.

<a name='M-SlackWebhook-Messages-SlackAttachmentField-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate(validationErrors) `method`

##### Summary

Validates the current state of the attachment field

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationErrors | [System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@') |  |

<a name='T-SlackWebhook-Messages-SlackMessage'></a>
## SlackMessage `type`

##### Namespace

SlackWebhook.Messages

##### Summary

Basis for a Slack message which can be sent to the webhook URL

<a name='P-SlackWebhook-Messages-SlackMessage-Attachments'></a>
### Attachments `property`

##### Summary

Attachments to show below message (optional)

<a name='P-SlackWebhook-Messages-SlackMessage-Channel'></a>
### Channel `property`

##### Summary

Channel the message is posted into (optional)

<a name='P-SlackWebhook-Messages-SlackMessage-EnableFormatting'></a>
### EnableFormatting `property`

##### Summary

Whether or not to enable formatting for this message

##### Remarks

Default true

<a name='P-SlackWebhook-Messages-SlackMessage-IconEmoji'></a>
### IconEmoji `property`

##### Summary

Icon emoji name () (optional)

##### Remarks

Either provide this OR [IconUrl](#P-SlackWebhook-Messages-SlackMessage-IconUrl 'SlackWebhook.Messages.SlackMessage.IconUrl'), but not both

<a name='P-SlackWebhook-Messages-SlackMessage-IconUrl'></a>
### IconUrl `property`

##### Summary

Icon URL to show before username (optional)

##### Remarks

Either provide this OR [IconEmoji](#P-SlackWebhook-Messages-SlackMessage-IconEmoji 'SlackWebhook.Messages.SlackMessage.IconEmoji'), but not both

<a name='P-SlackWebhook-Messages-SlackMessage-Text'></a>
### Text `property`

##### Summary

Message text which may contain formatting (unless 
            [EnableFormatting](#P-SlackWebhook-Messages-SlackMessage-EnableFormatting 'SlackWebhook.Messages.SlackMessage.EnableFormatting')  is deactivated) and can span 
            multiple lines.

##### Remarks

You can use the regular Slack formatting

```
*bold* `code` _italic_ ~strike~
```

and also include links

```
&lt;URL|title&gt;
```

<a name='P-SlackWebhook-Messages-SlackMessage-Username'></a>
### Username `property`

##### Summary

Username shown (optional)

<a name='M-SlackWebhook-Messages-SlackMessage-ThrowIfInvalid'></a>
### ThrowIfInvalid() `method`

##### Summary

Checks the current state using [Validate](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)') and throws a 
            [SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException') with all validations erros, if any 
            are found.

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate() `method`

##### Summary

Validates the current state of the message (including any nested 
            elements, such as [Attachments](#P-SlackWebhook-Messages-SlackMessage-Attachments 'SlackWebhook.Messages.SlackMessage.Attachments'))

##### Returns

True if message is valid, false otherwise

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-Exceptions-ValidationError'></a>
## ValidationError `type`

##### Namespace

SlackWebhook.Exceptions

##### Summary

Validation error details
