# Demo-EventGrid-Trigger-Function
Demo-EventGrid-Trigger-Function

# Postman Testing steps given below
# URL:
    http://localhost:7256/runtime/webhooks/EventGrid?functionName=DemoEventGridTrigger
# Method: 
    POST
# Headers
	aeg-event-type: Notification
	Content-Type: application/json

# Body: 
	{
        "topic": "test-topic",
        "subject": "test-topic-subject",
        "eventTime": "2022-10-24T07:21:23.031Z",
        "eventType": "modified",
        "id": "product-id",
        "dataVersion": "V1",
        "data":{
            "id": "Product-Id",
            "Name": "Test Product",
            "Status": "Current"
        }
    }
