#TODO : The user and group of all the containers should be set to AID_VENDOR_KONFLUENCE once we are fully unprivileged
#containers.
#The containers need AID_ROOT for the time being to avoid the dac_read_search capability to the containers.
#Or Have a post processing script change the ownerhip of the files after the image is created.

