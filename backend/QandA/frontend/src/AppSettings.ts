export const server = 'https://localhost:44377';

export const webAPIUrl = `${server}/api`;

export const authSettings = {
  domain: 'dev-fpyxjzwy.us.auth0.com',
  client_id: 'YQzC6QhNWrmZtqyT6zJWYSbSSJrGY0VV',
  redirect_uri: window.location.origin + '/signin-callback',
  scope: 'openid profile QandAAPI email',
  audience: 'https://localhost:44377',
};
