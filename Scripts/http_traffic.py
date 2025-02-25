import requests
import json

BASE_URL = f"http://localhost:{5000}"

print(requests.get(BASE_URL+"/api/concerts").content)

