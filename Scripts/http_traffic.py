import requests
import json

BASE_URL = f"localhost:{0000}"

def get(endpoint):
    url = f"{BASE_URL}/{endpoint}"
    headers = {"Content-type": "application/json"}

    try:
        response = requests.get(url, headers=headers).content
    except requests.exceptions.RequestException as e:
        return e
    
print(requests.get(BASE_URL).content)
print(get("api/testmodel"))