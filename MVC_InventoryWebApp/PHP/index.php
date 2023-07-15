<?php
    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Get form data
    $name = $_POST['Name'];
    $email = $_POST['Email'];
    $message = $_POST['Message'];

    // Set the recipient email address
    $recipient = 'chaoscat7@protonmail.com';

    // Set the email subject
    $subject = 'New contact form submission';

    // Build the email content
    $content = "Name: $name\n";
    $content .= "Email: $email\n";
    $content .= "Message: $message\n";

    // Set additional headers
    $headers = "From: $name <$email>
    ";

    // Send the email
    if (mail($recipient, $subject, $content, $headers)) {
    echo 'Email sent successfully!';
    } else {
    echo 'Failed to send email.';
    }
    }

?>