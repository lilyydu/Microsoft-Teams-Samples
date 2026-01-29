// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

import { App } from '@microsoft/teams.apps'
import { DevtoolsPlugin } from '@microsoft/teams.dev';

const app = new App({
  plugins: [new DevtoolsPlugin()],
});

app.on('message', async ({ send, activity }) => {
  await send(`echo from node 🚀: "${activity.text}"`)
})

app.start().catch(console.error)