export const server = 'https://localhost:44377';

export const webAPIUrl = `${server}/api`;

export const authSettings = {
  domain: 'dev-fpyxjzwy.us.auth0.com',
  client_id: 'X4VWQ2uOEQKKxaOAuoUzpxXRwUpVuI4t',
  redirect_uri: window.location.origin + '/signin-callback',
  scope: 'openid profile QandAAPI email',
  audience: 'https://localhost:44377',
};
