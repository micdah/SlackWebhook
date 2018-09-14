# Changelog

## 1.0.24

* Added support for attachment link buttons (_type of attachment action_) which opens a provided URL if clicked,
  allowing you to add up to 5 buttons to each attachment.
  See [Attaching buttons to messages](https://api.slack.com/docs/message-attachments#attaching_buttons_to_messages)
  for more.
  
  **Example**:
    ```cs
    await client.SendAsync(b => b
        .WithText("Look at my buttons")
        .WithAttachment(a => a
            .WithTitle("Now with actions")
            .WithText("...which are pretty neat")
            .WithLinkButtonAction("Click me", "http://google.com", ActionStyle.Primary)
            .WithLinkButtonAction("Don't click me", "http://bing.com", ActionStyle.Danger)));
    ``` 

## 1.0.23

* First documented release with initial features provided by the Slack Webhook API