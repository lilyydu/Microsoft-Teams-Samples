# Echo Bot - Python

This sample demonstrates a simple Echo Bot for Microsoft Teams using Python.

## Prerequisites

- [Python 3.12+](https://www.python.org/downloads/)
- [uv](https://docs.astral.sh/uv/) (recommended) or pip

## Run the sample

1. Navigate to this directory:
   ```bash
   cd python/echo_bot
   ```

2. Install dependencies using uv:
   ```bash
   uv sync
   ```

3. Run the bot:
   ```bash
   uv run main.py
   ```

### Alternative: Using pip

```bash
pip install -e .
python main.py
```

The bot will start listening on `http://localhost:3978`.

Refer to the main [README.md](../../README.md) to interact with your bot in the agentsplayground or in Teams.